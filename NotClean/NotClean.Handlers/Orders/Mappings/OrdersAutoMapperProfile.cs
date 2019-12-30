using AutoMapper;
using NotClean.Entities;
using NotClean.Handlers.Orders.Dto;

namespace NotClean.Handlers.Orders.Mappings
{
    public class OrdersAutoMapperProfile : Profile
    {
        public OrdersAutoMapperProfile()
        {
            CreateMap<Order, OrderDto>()
                .ForMember(x => x.Price, opt => opt.Ignore());

            CreateMap<CreateOrderDto, Order>();
            CreateMap<OrderItemDto, OrderItem>();
        }
    }
}
