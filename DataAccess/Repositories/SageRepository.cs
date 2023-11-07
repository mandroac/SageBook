using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class SageRepository : BaseRepository<Sage>, ISageRepository
    {
        public SageRepository(SageBookDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<IEnumerable<Sage>> GetAllAsync() =>
            await DbContext.Sages.Include(s => s.Books).ToListAsync();

        public override async Task<Sage> GetAsync(Guid id) =>
            await DbContext.Sages.Include(s => s.Books).SingleOrDefaultAsync(s => s.Id == id);
    }
}
