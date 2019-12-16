using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Max.DomainServices.Interfaces;
using Max.Infrastructure.Interfaces.DataAccess;
using Max.UseCases.Exceptions;
using Max.UseCases.Handlers.Orders.Dto;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Max.UseCases.Handlers.Orders.Queries.GetOrder
{
    internal class GetOrderRequestHandler : IRequestHandler<GetOrderRequest, OrderDto>
    {
        private readonly IDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IOrdersService _orderService;

        public GetOrderRequestHandler(IDbContext dbContext, IMapper mapper, IOrdersService orderService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _orderService = orderService;
        }

        public async Task<OrderDto> Handle(GetOrderRequest request, CancellationToken cancellationToken)
        {
            var order = await _dbContext.Orders
                .Include(x => x.Items).ThenInclude(x => x.Product)
                .SingleOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (order == null) throw new EntityNotFoundException();

            var result = _mapper.Map<OrderDto>(order);
            result.Price = _orderService.GetPrice(order);
            
            return result;
        }
    }
}
