using Max.UseCases.Handlers.Orders.Dto;
using MediatR;

namespace Max.UseCases.Handlers.Orders.Queries.GetOrder
{
    public class GetOrderRequest : IRequest<OrderDto>
    {
        public int Id { get; set; }
    }
}
