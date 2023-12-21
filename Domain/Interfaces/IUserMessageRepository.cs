using Domain.Models;

namespace Domain.Interfaces
{
    public interface IUserMessageRepository : IBaseRepository<UserMessage>
    {
        Task<ICollection<UserMessage>> GetChatMessagesAsync(Guid firstUserId, Guid secondUserId);
    }
}
