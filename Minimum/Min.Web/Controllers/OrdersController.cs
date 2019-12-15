using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Min.Entities;
using Min.UseCases.Handlers.Orders.Commands.CreateOrder;
using Min.UseCases.Handlers.Orders.Dto;
using Min.UseCases.Handlers.Orders.Queries.GetOrder;

namespace Min.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET api/orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> Get(int id)
        {
            return await _mediator.Send(new GetOrderRequest {Id = id});
        }

        // POST api/orders
        [HttpPost]
        public async Task Post([FromBody] OrderDto orderDto)
        {
            await _mediator.Send(new CreateOrderRequest {OrderDto = orderDto});
        }
    }
}
