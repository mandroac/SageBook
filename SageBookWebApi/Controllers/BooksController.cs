using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SageBookWebApi.Requests;
using Swashbuckle.AspNetCore.Annotations;

namespace SageBookWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly ISageRepository _sageRepository;

        public BooksController(IBookRepository bookRepository, ISageRepository sageRepository)
        {
            _bookRepository = bookRepository;
            _sageRepository = sageRepository;
        }

        // GET: api/<BooksController>
        [HttpGet]
        [SwaggerOperation("Get all books.")]
        public async Task<IActionResult> GetAsync()
        {
            var books = await _bookRepository.GetAllAsync();
            return Ok(books);
        }

        // GET api/<BooksController>/{id}
        [HttpGet("{id}")]
        [SwaggerOperation("Get single book by id.")]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            var book = await _bookRepository.GetAsync(id);
            return Ok(book);
        }

        // POST api/<BooksController>
        [HttpPost]
        [Authorize("RequireAdmin")]
        [SwaggerOperation("ADMIN ONLY. Create a new book.")]
        public async Task<IActionResult> PostAsync([FromBody] BookRequest bookRequest)
        {
            var book = new Book
            {
                Name = bookRequest.Name,
                Description = bookRequest.Description
            };

            if (bookRequest.SageIds.Any())
            {
                var sages = await _sageRepository.GetRangeAsync(bookRequest.SageIds);
                book.Sages = sages.ToList();
            }

            await _bookRepository.CreateAsync(book);
            return Ok();
        }

        // PUT api/<BooksController>/{id}
        [HttpPut("{id}")]
        [Authorize("RequireAdmin")]
        [SwaggerOperation("ADMIN ONLY. Update existing book.")]
        public async Task<IActionResult> PutAsync(Guid id, [FromBody] BookRequest bookRequest)
        {
            var book = await _bookRepository.GetAsync(id);

            if (book is null)
            {
                return NotFound($"Book with id {id} was not found");
            }

            book.Name = bookRequest.Name;
            book.Description = bookRequest.Description;

            if (bookRequest.SageIds.Any())
            {
                var sages = await _sageRepository.GetRangeAsync(bookRequest.SageIds);
                book.Sages = sages.ToList();
            }
            else
                book.Sages = null;

            await _bookRepository.UpdateAsync(book);
            return Ok();
        }

        // DELETE api/<BooksController>/{id}
        [HttpDelete("{id}")]
        [Authorize("RequireAdmin")]
        [SwaggerOperation("ADMIN ONLY. Delete book.")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var book = await _bookRepository.GetAsync(id);

            if (book is null)
            {
                return NotFound($"Book with id {id} was not found");
            }

            await _bookRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
