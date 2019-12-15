using MediatR;
using Min.Entities;

namespace Min.UseCases.Handlers.Orders.Queries.GetOrder
{
    public class GetOrderRequest : IRequest<Order>
    {
        public int Id { get; set; }
    }
}
