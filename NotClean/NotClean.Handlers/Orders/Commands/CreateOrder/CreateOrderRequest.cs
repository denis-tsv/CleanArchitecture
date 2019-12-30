using MediatR;
using NotClean.Handlers.Orders.Dto;

namespace NotClean.Handlers.Orders.Commands.CreateOrder
{
    public class CreateOrderRequest : IRequest
    {
        public CreateOrderDto CreateOrderDto { get; set; }
    }
}
