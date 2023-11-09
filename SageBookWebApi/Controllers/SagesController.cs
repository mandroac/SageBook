using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SageBookWebApi.Requests;
using Swashbuckle.AspNetCore.Annotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SageBookWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("RequireAdmin")]
    public class SagesController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly ISageRepository _sageRepository;

        public SagesController(IBookRepository bookRepository, ISageRepository sageRepository)
        {
            _bookRepository = bookRepository;
            _sageRepository = sageRepository;
        }

        // GET: api/<SagesController>
        [HttpGet]
        [AllowAnonymous]
        [SwaggerOperation("Get all sages.")]
        public async Task<IActionResult> GetAsync()
        {
            var sages = await _sageRepository.GetAllAsync();
            return Ok(sages);
        }

        // GET api/<SagesController>/{id}
        [HttpGet("{id}")]
        [AllowAnonymous]
        [SwaggerOperation("Get a single sage by id.")]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            var sage = await _sageRepository.GetAsync(id);
            return Ok(sage);
        }

        // POST api/<SagesController>
        [HttpPost]
        [SwaggerOperation("ADMIN ONLY. Create new sage.")]
        public async Task<IActionResult> PostAsync([FromBody] SageRequest sageRequest)
        {
            var sage = new Sage
            {
                Name = sageRequest.Name,
                Age = sageRequest.Age,
                City = sageRequest.City,
            };

            if (sageRequest.BookIds.Any())
            {
                var books = await _bookRepository.GetRangeAsync(sageRequest.BookIds);
                sage.Books = books.ToList();
            }

            if (sageRequest.Photo is not null)
            {
                using var ms = new MemoryStream();
                sageRequest.Photo.CopyTo(ms);
                ms.Seek(0, SeekOrigin.Begin);

                sage.Photo = ms.ToArray();
            }

            await _sageRepository.CreateAsync(sage);
            return Ok();
        }

        // PUT api/<SagesController>/{id}
        [HttpPut("{id}")]
        [SwaggerOperation("ADMIN ONLY. Update existing sage.")]
        public async Task<IActionResult> PutAsync(Guid id, [FromBody] SageRequest sageRequest)
        {
            var sage = await _sageRepository.GetAsync(id);

            if (sage is null)
            {
                return NotFound($"Sage with id {id} was not found");
            }

            sage.Name = sageRequest.Name;
            sage.Age = sageRequest.Age;
            sage.City = sageRequest.City;

            if (sageRequest.BookIds.Any())
            {
                var books = await _bookRepository.GetRangeAsync(sageRequest.BookIds);
                sage.Books = books.ToList();
            }
            else
                sage.Books = null;

            if (sageRequest.Photo != null)
            {
                using var ms = new MemoryStream();
                sageRequest.Photo.CopyTo(ms);
                ms.Seek(0, SeekOrigin.Begin);

                sage.Photo = ms.ToArray();
            }

            await _sageRepository.UpdateAsync(sage);
            return Ok();
        }

        // DELETE api/<SagesController>/{id}
        [HttpDelete("{id}")]
        [SwaggerOperation("ADMIN ONLY. Delete sage.")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var sage = await _sageRepository.GetAsync(id);

            if (sage is null)
            {
                return NotFound($"Sage with id {id} was not found");
            }

            await _sageRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
