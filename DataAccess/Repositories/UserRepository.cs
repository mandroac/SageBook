using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SageBookDbContext _dbContext;

        public UserRepository(SageBookDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<AppUser> GetUserAsync(Guid userId) =>
            await _dbContext.Users.FindAsync(userId);
    }
}
