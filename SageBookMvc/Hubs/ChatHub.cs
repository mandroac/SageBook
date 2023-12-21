using Domain.Models;
using Microsoft.AspNetCore.SignalR;

namespace SageBookMvc.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendBookMessageAsync(BookMessage message)
        {
            await Clients.All.SendAsync("ReceiveBookChatMessage", message);
        }

        public async Task SendUserMessageAsync(UserMessage message)
        {
            await Clients.All.SendAsync("ReceiveUserChatMessage", message);
        }
    }
}
