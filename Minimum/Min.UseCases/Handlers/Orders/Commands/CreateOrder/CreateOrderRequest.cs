using MediatR;
using Min.UseCases.Handlers.Orders.Dto;

namespace Min.UseCases.Handlers.Orders.Commands.CreateOrder
{
    public class CreateOrderRequest : IRequest
    {
        public OrderDto OrderDto { get; set; }
    }
}
