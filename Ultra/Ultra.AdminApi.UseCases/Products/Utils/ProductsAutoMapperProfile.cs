using AutoMapper;
using Ultra.Common.Domain.Entities.Models;
using Ultra.Web.AdminApi.UseCases.Products.Dtos;

namespace Ultra.Web.AdminApi.UseCases.Products.Utils
{
    public class ProductsAutoMapperProfile : Profile
    {
        public ProductsAutoMapperProfile()
        {
            CreateMap<AddProductDto, Product>();
        }
    }
}
