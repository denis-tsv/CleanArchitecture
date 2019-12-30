using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NotClean.DataAccess;
using NotClean.Handlers.Exceptions;
using NotClean.Handlers.Orders.Dto;

namespace NotClean.Handlers.Orders.Queries.GetOrder
{
    public class GetOrderRequestHandler : IRequestHandler<GetOrderRequest, OrderDto>
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetOrderRequestHandler(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<OrderDto> Handle(GetOrderRequest request, CancellationToken cancellationToken)
        {
            var order = await _dbContext.Orders.AsNoTracking()
                .Include(x => x.Items).ThenInclude(x => x.Product)
                .SingleOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (order == null) throw new EntityNotFoundException();

            var result = _mapper.Map<OrderDto>(order);
            result.Price = order.Items.Sum(x => x.Count * x.Product.Price);

            return result;
        }
    }
}
