using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SageBookMvc.Hubs;
using SageBookMvc.Models;

namespace SageBookMvc.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ISageRepository _sageRepository;
        private readonly ChatHub _chatHub;

        public BooksController(
            IBookRepository bookRepository,
            ISageRepository sageRepository,
            ChatHub chatHub)
        {
            _bookRepository = bookRepository;
            _sageRepository = sageRepository;
            _chatHub = chatHub;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            var books = await _bookRepository.GetAllAsync();

            return books != null ? View(books) : Problem("No books found.");
        }

        // GET: Books/Details/{id}
        public async Task<IActionResult> Details(Guid id)
        {
            var book = await _bookRepository.GetAsync(id);

            return book != null ? View(book) : NotFound();
        }

        // GET: Books/Create
        public async Task<IActionResult> Create()
        {
            var sages = await _sageRepository.GetAllAsync();
            var model = new EditBookViewModel
            {
                SagesSelectedList = sages.Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.ToString()
                }).ToList()
            };
            return View(model);
        }

        // POST: Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EditBookViewModel createBook)
        {
            if (ModelState.IsValid)
            {
                var selectedSages = await _sageRepository.GetRangeAsync(createBook.SelectedSageIds);
                createBook.Book.Sages = selectedSages.ToList();
                var result = await _bookRepository.CreateAsync(createBook.Book);

                return RedirectToAction(nameof(Index));
            }
            return View(createBook);
        }

        // GET: Books/Edit/{id}
        public async Task<IActionResult> Edit(Guid id)
        {
            var book = await _bookRepository.GetAsync(id);
            var sages = await _sageRepository.GetAllAsync();
            var model = new EditBookViewModel
            {
                Book = book,
                SagesSelectedList = sages.Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.ToString()
                }).ToList(),
                SelectedSageIds = book.Sages.Select(s => s.Id).ToList()
            };

            return book == null ? NotFound() : View(model);
        }

        // POST: Books/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, EditBookViewModel editBook)
        {
            if (id != editBook.Book.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var book = await _bookRepository.GetAsync(id);
                    var selectedSages = await _sageRepository.GetRangeAsync(editBook.SelectedSageIds);

                    book.Name = editBook.Book.Name;
                    book.Description = editBook.Book.Description;
                    book.Sages = selectedSages.ToList();

                    await _bookRepository.UpdateAsync(book);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(editBook.Book.Id))
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
            return View(editBook);
        }

        // GET: Books/Delete/{id}
        public async Task<IActionResult> Delete(Guid id)
        {
            var book = await _bookRepository.GetAsync(id);

            return book == null ? NotFound() : View(book);
        }

        // POST: Books/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var result = await _bookRepository.DeleteAsync(id);

            return result == null ? Problem($"Book with id {id} was not found.") : RedirectToAction(nameof(Index));
        }

        private bool BookExists(Guid id) => _bookRepository.GetAsync(id) != null;
    }
}
