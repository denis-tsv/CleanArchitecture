using MediatR;
using Mid.UseCases.Handlers.Orders.Dto;

namespace Mid.UseCases.Handlers.Orders.Queries.GetOrder
{
    public class GetOrderRequest : IRequest<OrderDto>
    {
        public int Id { get; set; }
    }
}
