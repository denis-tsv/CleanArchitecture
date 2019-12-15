using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Min.Entities;
using Min.Infrastructure.Interfaces.DataAccess;
using Min.UseCases.Exceptions;

namespace Min.UseCases.Handlers.Orders.Queries.GetOrder
{
    public class GetOrderRequestHandler : IRequestHandler<GetOrderRequest, Order>
    {
        private readonly IDbContext _dbContext;

        public GetOrderRequestHandler(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Order> Handle(GetOrderRequest request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Orders.FindAsync(request.Id);

            if (result == null) throw new EntityNotFoundException();

            return result;
        }
    }
}
