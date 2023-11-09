using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SageBookWebApi.Extensions;

namespace SageBookWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        public const string ShoppingCartSessionKey = "ShoppingCartSession";
        private readonly IBookRepository _bookRepository;

        public ShoppingCartController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpPost("AddBook/{id}")]
        public async Task<IActionResult> AddBookAsync(Guid id)
        {
            var book = await _bookRepository.GetAsync(id);

            if (book == null)
            {
                return NotFound($"Book with id {id} was not found.");
            }

            HttpContext.Session.AddBook(book);
            return Ok();
        }

        [HttpDelete("RemoveBook/{id}")]
        public IActionResult RemoveBook(Guid id)
        {
            HttpContext.Session.RemoveBook(id);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(HttpContext.Session.GetBooks());
        }
    }
}
