using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SageBookWebApi.Extensions;
using Swashbuckle.AspNetCore.Annotations;

namespace SageBookWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IBookRepository _bookRepository;

        public OrdersController(IOrderRepository orderRepository, IBookRepository bookRepository)
        {
            _orderRepository = orderRepository;
            _bookRepository = bookRepository;
        }

        [HttpGet]
        [Authorize("RequireAdmin")]
        [SwaggerOperation("ADMIN ONLY. Get all orders.")]
        public async Task<IActionResult> GetAsync()
        {
            var orders = await _orderRepository.GetAllAsync();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        [Authorize("RequireAdmin")]
        [SwaggerOperation("ADMIN ONLY. Get a single order by id.")]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            var order = await _orderRepository.GetAsync(id);
            return Ok(order);
        }

        [HttpPost("SubmitOrder")]
        [Authorize]
        [SwaggerOperation("AUTHORIZED USER ONLY. Submit new order.")]
        public async Task<IActionResult> SubmitOrderAsync()
        {
            var books = HttpContext.Session.GetBooks();
            if (!books.Any())
            {
                return BadRequest("No books added to the shopping cart");
            }

            var userId = User.GetUserId();
            if (userId == Guid.Empty)
            {
                return Unauthorized("User must log in before submitting an order");
            }

            //get books from db to avoid EF issues
            books = await _bookRepository.GetRangeAsync(books.Select(x => x.Id).ToArray());

            var order = new Order
            {
                UserId = userId,
                Books = books.ToList()
            };

            await _orderRepository.CreateAsync(order);
            return Ok();
        }
    }
}
