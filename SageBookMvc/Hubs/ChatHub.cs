using Domain.Models;
using Microsoft.AspNetCore.SignalR;

namespace SageBookMvc.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessageAsync(Message message)
        {
            await Clients.All.SendAsync("ReceiveChatMessage", message);
        }
    }
}
