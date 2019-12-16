using AutoMapper;
using Max.Entities;
using Max.UseCases.Handlers.Orders.Dto;

namespace Max.UseCases.Handlers.Orders.Mappings
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
