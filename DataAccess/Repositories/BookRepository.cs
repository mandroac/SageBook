using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(SageBookDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<IEnumerable<Book>> GetAllAsync() =>
            await DbContext.Books.Include(b => b.Sages).ToListAsync();

        public override async Task<Book> GetAsync(Guid id) =>
            await DbContext.Books
                .Include(b => b.Sages)
                .Include(b => b.Messages)
                    .ThenInclude(m => m.Sender)
                .SingleOrDefaultAsync(b => b.Id == id);
    }
}
