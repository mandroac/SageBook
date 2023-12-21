using Domain.Models;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<AppUser> GetUserAsync(Guid userId);
    }
}
