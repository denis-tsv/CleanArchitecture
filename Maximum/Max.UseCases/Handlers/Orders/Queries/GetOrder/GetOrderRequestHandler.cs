using System.Threading;
using System.Threading.Tasks;
using Max.Entities;
using Max.Infrastructure.Interfaces.DataAccess;
using Max.UseCases.Exceptions;
using MediatR;

namespace Max.UseCases.Handlers.Orders.Queries.GetOrder
{
    internal class GetOrderRequestHandler : IRequestHandler<GetOrderRequest, Order>
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
