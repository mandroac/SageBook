using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SageBookMvc.Extensions;
using SageBookMvc.Models;
using System.Diagnostics;

namespace SageBookMvc.Controllers
{
    public class HomeController : Controller
    {
        public const string ShoppingCartSessionKey = "ShoppingCartSession";
        private readonly IBookRepository _bookRepository;
        private readonly IOrderRepository _orderRepository;

        public HomeController(IBookRepository bookRepository, IOrderRepository orderRepository)
        {
            _bookRepository = bookRepository;
            _orderRepository = orderRepository;
        }
        public async Task<IActionResult> Index()
        {
            var books = await _bookRepository.GetAllAsync();
            return View(books);
        }

        public IActionResult ShoppingCart()
        {
            var books = HttpContext.Session.GetBooks();
            return View(books);
        }

        public async Task<IActionResult> SubmitOrder()
        {
            var userId = User.GetUserId();
            if (userId == Guid.Empty)
            {
                return Problem("Failed to determine user identity");
            }

            var selectedBooks = HttpContext.Session.GetBooks();
            if (!selectedBooks.Any())
            {
                return Problem("Shopping cart is empty");
            }

            var books = await _bookRepository.GetRangeAsync(selectedBooks.Select(b => b.Id).ToList());

            var order = new Order
            {
                Books = books.ToList(),
                UserId = userId
            };
            await _orderRepository.CreateAsync(order);

            HttpContext.Session.SetObject(null, ShoppingCartSessionKey);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> AddToCart(Guid bookId)
        {
            var book = await _bookRepository.GetAsync(bookId);
            HttpContext.Session.AddBook(book);

            return RedirectToAction(nameof(Index));
        }
        public IActionResult RemoveFromCart(Guid bookId)
        {
            var sessionBooks = HttpContext.Session.GetBooks() as List<Book>;
            sessionBooks?.RemoveAll(book => book.Id == bookId);
            HttpContext.Session.SetObject(sessionBooks, ShoppingCartSessionKey);

            return RedirectToAction(nameof(Index));
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}