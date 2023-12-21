using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class UserMessageRepository : BaseRepository<UserMessage>, IUserMessageRepository
    {
        public UserMessageRepository(SageBookDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<ICollection<UserMessage>> GetChatMessagesAsync(Guid firstUserId, Guid secondUserId) =>
            await DbContext.UserMessages.Include(m => m.Sender).Include(m => m.Receiver)
                .Where(m => (m.SenderId == firstUserId && m.ReceiverId == secondUserId) ||
                (m.SenderId == secondUserId && m.ReceiverId == firstUserId)).ToListAsync();

    }
}
