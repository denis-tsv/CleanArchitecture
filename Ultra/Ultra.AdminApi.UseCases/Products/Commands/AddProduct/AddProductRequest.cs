using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Ultra.AdminApi.UseCases.Products.Dtos;

namespace Ultra.AdminApi.UseCases.Products.Commands.AddProduct
{
    public class AddProductRequest : IRequest<int>
    {
        public AddProductDto AddProductDto { get; set; }
    }
}
