using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace SageBookMvc.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public OrdersController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        // GET: OrderController
        public async Task<IActionResult> Index()
        {
            var orders = await _orderRepository.GetAllAsync();
            return View(orders);
        }

        public async Task<IActionResult> Details(Guid orderId)
        {
            var order = await _orderRepository.GetAsync(orderId);
            return View(order);
        }
    }
}
