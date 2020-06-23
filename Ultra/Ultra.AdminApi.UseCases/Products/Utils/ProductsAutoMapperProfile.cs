using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Ultra.AdminApi.UseCases.Products.Dtos;
using Ultra.Entities.Models;

namespace Ultra.AdminApi.UseCases.Products.Utils
{
    public class ProductsAutoMapperProfile : Profile
    {
        public ProductsAutoMapperProfile()
        {
            CreateMap<AddProductDto, Product>();
        }
    }
}
