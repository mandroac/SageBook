using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using SageBookWebApi.Requests;

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
        //[SwaggerResponse(HttpStatusCode.OK, Type = typeof(IEnumerable<Country>))]
        //[SwaggerResponseExample(HttpStatusCode.OK, typeof(CountryExamples))]
        public async Task<IActionResult> GetAsync()
        {
            var books = await _bookRepository.GetAllAsync();
            return Ok(books);
        }

        // GET api/<BooksController>/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            var book = await _bookRepository.GetAsync(id);
            return Ok(book);
        }

        // POST api/<BooksController>
        [HttpPost]
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
