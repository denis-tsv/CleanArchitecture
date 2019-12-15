using AutoMapper;
using Min.Entities;
using Min.UseCases.Handlers.Orders.Dto;

namespace Min.UseCases.Handlers.Orders.Mappings
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
