using AutoMapper;
using Max.Entities;
using Max.UseCases.Handlers.Orders.Dto;

namespace Max.UseCases.Handlers.Orders.Mappings
{
    public class OrdersAutoMapperProfile : Profile
    {
        public OrdersAutoMapperProfile()
        {
            CreateMap<OrderDto, Order>();
            CreateMap<OrderItemDto, OrderItem>();
        }
    }
}
