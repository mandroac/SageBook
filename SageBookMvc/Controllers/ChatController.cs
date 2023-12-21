using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using SageBookMvc.Extensions;
using SageBookMvc.Hubs;
using SageBookMvc.Models;

namespace SageBookMvc.Controllers
{
    public class ChatController : Controller
    {
        private readonly IUserMessageRepository _userMessageRepository;
        private readonly IUserRepository _userRepository;
        private readonly IBookRepository _bookRepository;
        private readonly ChatHub _chatHub;

        public ChatController(
            IUserMessageRepository userMessageRepository,
            IUserRepository userRepository,
            IBookRepository bookRepository,
            ChatHub chatHub)
        {
            _userMessageRepository = userMessageRepository;
            _userRepository = userRepository;
            _bookRepository = bookRepository;
            _chatHub = chatHub;
        }

        public async Task<IActionResult> UserChat(Guid collocutorId)
        {
            var currentUserId = User.GetUserId();
            var messages = await _userMessageRepository.GetChatMessagesAsync(currentUserId, collocutorId);
            var currentUser = await _userRepository.GetUserAsync(currentUserId);
            var collocutor = await _userRepository.GetUserAsync(collocutorId);

            var userChatViewModel = new UserChatViewModel
            {
                FirstUser = currentUser,
                SecondUser = collocutor,
                Messages = messages
            };

            return View(userChatViewModel);
        }

        public async Task<IActionResult> SendBookMessage(string messageContent, Guid bookId)
        {
            var userId = User.GetUserId();
            var message = new BookMessage
            {
                SenderId = userId,
                SendDate = DateTime.Now,
                Content = messageContent,
                BookId = bookId
            };

            var book = await _bookRepository.GetAsync(bookId);
            book.Messages.Add(message);
            await _bookRepository.UpdateAsync(book);
            await _chatHub.SendBookMessageAsync(message);

            return Ok();
        }

        public async Task<IActionResult> SendUserMessage(string messageContent, Guid collocutorId)
        {
            var userId = User.GetUserId();
            var sender = await _userRepository.GetUserAsync(userId);
            var message = new UserMessage
            {
                SenderId = userId,
                Sender = sender,
                SendDate = DateTime.Now,
                Content = messageContent,
                ReceiverId = collocutorId
            };
            await _userMessageRepository.CreateAsync(message);

            await _chatHub.SendUserMessageAsync(message);

            return Ok();
        }
    }
}
