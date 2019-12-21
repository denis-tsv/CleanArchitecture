using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Mid.UseCases.Handlers.Orders.Commands.CreateOrder;
using Mid.UseCases.Handlers.Orders.Dto;
using Mid.UseCases.Handlers.Orders.Queries.GetOrder;

namespace Mid.Web.Controllers
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
        public async Task<ActionResult<OrderDto>> Get(int id)
        {
            return await _mediator.Send(new GetOrderRequest {Id = id});
        }

        // POST api/orders
        [HttpPost]
        public async Task Post([FromBody] CreateOrderDto createOrderDto)
        {
            await _mediator.Send(new CreateOrderRequest {CreateOrderDto = createOrderDto});
        }
    }
}
