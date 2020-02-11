using AutoMapper;
using Mid.Entities.Models;
using Mid.UseCases.Handlers.Orders.Dto;

namespace Mid.UseCases.Handlers.Orders.Mappings
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
