using Max.Entities;
using MediatR;

namespace Max.UseCases.Handlers.Orders.Queries.GetOrder
{
    public class GetOrderRequest : IRequest<Order>
    {
        public int Id { get; set; }
    }
}
