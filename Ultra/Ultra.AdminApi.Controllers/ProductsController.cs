using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Ultra.Web.AdminApi.UseCases.Products.Commands.AddProduct;
using Ultra.Web.AdminApi.UseCases.Products.Dtos;

namespace Ultra.Web.AdminApi.Controllers
{
    public class ProductsController: ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public Task<int> AddProduct([FromBody] AddProductDto dto)
        {
            return _mediator.Send(new AddProductRequest {AddProductDto = dto});
        }
    }
}
