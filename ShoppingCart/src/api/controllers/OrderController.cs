using Bookshop_be.src.application.Commands;
using Bookshop_be.src.application.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bookshop_be.src.API.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<int>> SaveOrder([FromBody] OrderDto orderDto)
        {
            var orderId = await _mediator.Send(new SaveOrderCommand(orderDto));
            return Ok(orderId);
        }
    }
}