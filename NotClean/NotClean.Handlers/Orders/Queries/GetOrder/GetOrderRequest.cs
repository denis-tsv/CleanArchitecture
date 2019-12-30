using MediatR;
using NotClean.Handlers.Orders.Dto;

namespace NotClean.Handlers.Orders.Queries.GetOrder
{
    public class GetOrderRequest : IRequest<OrderDto>
    {
        public int Id { get; set; }
    }
}
