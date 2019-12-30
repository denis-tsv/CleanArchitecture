using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Min.Infrastructure.Interfaces.DataAccess;
using Min.UseCases.Exceptions;
using Min.UseCases.Handlers.Orders.Dto;

namespace Min.UseCases.Handlers.Orders.Queries.GetOrder
{
    public class GetOrderRequestHandler : IRequestHandler<GetOrderRequest, OrderDto>
    {
        private readonly IDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetOrderRequestHandler(IDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<OrderDto> Handle(GetOrderRequest request, CancellationToken cancellationToken)
        {
            var order = await _dbContext.Orders.AsNoTracking()
                .Include(x => x.Items).ThenInclude(x => x.Product)
                .SingleOrDefaultAsync(x => x.Id ==  request.Id, cancellationToken: cancellationToken);

            if (order == null) throw new EntityNotFoundException();

            var result = _mapper.Map<OrderDto>(order);
            result.Price = order.GetPrice();

            return result;
        }
    }
}
