using Max.UseCases.Handlers.Orders.Dto;
using MediatR;

namespace Max.UseCases.Handlers.Orders.Commands.CreateOrder
{
    public class CreateOrderRequest : IRequest
    {
        public OrderDto OrderDto { get; set; }
    }
}
