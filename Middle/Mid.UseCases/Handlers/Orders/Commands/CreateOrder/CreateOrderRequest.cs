using MediatR;
using Mid.UseCases.Handlers.Orders.Dto;

namespace Mid.UseCases.Handlers.Orders.Commands.CreateOrder
{
    public class CreateOrderRequest : IRequest
    {
        public CreateOrderDto CreateOrderDto { get; set; }
    }
}
