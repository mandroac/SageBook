using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(SageBookDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<IEnumerable<Order>> GetAllAsync() =>
            await DbContext.Orders
                .Include(o => o.User)
                .Include(o => o.Books)
                .ToListAsync();

        public override async Task<Order> GetAsync(Guid id) =>
            await DbContext.Orders
                .Include(o => o.User)
                .Include(o => o.Books)
                .SingleOrDefaultAsync(o => o.Id == id);
    }
}
