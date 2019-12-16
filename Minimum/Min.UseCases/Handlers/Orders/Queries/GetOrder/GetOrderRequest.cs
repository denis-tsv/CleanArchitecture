using MediatR;
using Min.UseCases.Handlers.Orders.Dto;

namespace Min.UseCases.Handlers.Orders.Queries.GetOrder
{
    public class GetOrderRequest : IRequest<OrderDto>
    {
        public int Id { get; set; }
    }
}
