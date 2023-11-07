using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SageBookMvc.Models;

namespace SageBookMvc.Controllers
{
    public class SagesController : Controller
    {
        private readonly ISageRepository _sageRepository;
        private readonly IBookRepository _bookRepository;

        public SagesController(ISageRepository sageRepository, IBookRepository bookRepository)
        {
            _sageRepository = sageRepository;
            _bookRepository = bookRepository;
        }

        // GET: Sages
        public async Task<IActionResult> Index()
        {
            var sages = await _sageRepository.GetAllAsync();

            return sages != null ? View(sages) : Problem("No sages found.");
        }

        // GET: Sages/Details/{id}
        public async Task<IActionResult> Details(Guid id)
        {
            var sage = await _sageRepository.GetAsync(id);

            return sage != null ? View(sage) : NotFound();
        }

        // GET: Sages/Create
        public async Task<IActionResult> Create()
        {
            var books = await _bookRepository.GetAllAsync();
            var model = new EditSageViewModel
            {
                BooksSelectedList = books.Select(b => new SelectListItem
                {
                    Value = b.Id.ToString(),
                    Text = b.ToString()
                }).ToList()
            };
            return View(model);
        }

        // POST: Sages/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EditSageViewModel createSage)
        {
            if (ModelState.IsValid)
            {
                var selectedBooks = await _bookRepository.GetRangeAsync(createSage.SelectedBookIds);
                createSage.Sage.Books = selectedBooks.ToList();
                var result = await _sageRepository.CreateAsync(createSage.Sage);

                return RedirectToAction(nameof(Index));
            }
            return View(createSage);
        }

        // GET: Sages/Edit/{id}
        public async Task<IActionResult> Edit(Guid id)
        {
            var books = await _bookRepository.GetAllAsync();
            var sage = await _sageRepository.GetAsync(id);

            var model = new EditSageViewModel
            {
                Sage = sage,
                BooksSelectedList = books.Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.ToString()
                }).ToList(),
                SelectedBookIds = sage.Books.Select(b => b.Id).ToList()
            };

            return sage == null ? NotFound() : View(model);
        }

        // POST: Sages/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, EditSageViewModel editSage)
        {
            if (id != editSage.Sage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var sage = await _sageRepository.GetAsync(id);
                    var selectedBooks = await _bookRepository.GetRangeAsync(editSage.SelectedBookIds);

                    sage.Name = editSage.Sage.Name;
                    sage.City = editSage.Sage.City;
                    sage.Age = editSage.Sage.Age;
                    sage.Books = selectedBooks.ToList();

                    var photos = Request.Form.Files;
                    if (photos != null && photos.Any())
                    {
                        using var ms = new MemoryStream();
                        photos[0].OpenReadStream().CopyTo(ms);
                        ms.Seek(0, SeekOrigin.Begin);
                        sage.Photo = ms.ToArray();
                    }

                    await _sageRepository.UpdateAsync(sage);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SageExists(editSage.Sage.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(editSage);
        }

        // GET: Sage/Delete/{id}
        public async Task<IActionResult> Delete(Guid id)
        {
            var sage = await _sageRepository.GetAsync(id);

            return sage == null ? NotFound() : View(sage);
        }

        // POST: Sage/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var result = await _sageRepository.DeleteAsync(id);

            return result == null ? Problem($"Sage with id {id} was not found.") : RedirectToAction(nameof(Index));
        }

        private bool SageExists(Guid id) => _sageRepository.GetAsync(id) != null;
    }
}
