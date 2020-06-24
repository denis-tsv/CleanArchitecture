using MediatR;
using Ultra.Web.AdminApi.UseCases.Products.Dtos;

namespace Ultra.Web.AdminApi.UseCases.Products.Commands.AddProduct
{
    public class AddProductRequest : IRequest<int>
    {
        public AddProductDto AddProductDto { get; set; }
    }
}
