using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public abstract class BaseRepository<TModel> : IBaseRepository<TModel>
        where TModel : BaseModel, new()
    {
        protected readonly SageBookDbContext DbContext;

        public BaseRepository(SageBookDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public virtual async Task<TModel> CreateAsync(TModel entity)
        {
            var result = await DbContext.AddAsync(entity);
            await DbContext.SaveChangesAsync();

            return result.Entity;
        }

        public virtual async Task<TModel> DeleteAsync(Guid id)
        {
            var result = DbContext.Remove(new TModel { Id = id });
            await DbContext.SaveChangesAsync();

            return result.Entity;
        }

        public virtual async Task<IEnumerable<TModel>> GetAllAsync() =>
            await DbContext.Set<TModel>().ToListAsync();

        public virtual async Task<TModel> GetAsync(Guid id) =>
            await DbContext.Set<TModel>().FindAsync(id);

        public virtual async Task<IEnumerable<TModel>> GetRangeAsync(ICollection<Guid> ids) =>
            await DbContext.Set<TModel>().Where(m => ids.Contains(m.Id)).ToListAsync();

        public virtual async Task<TModel> UpdateAsync(TModel entity)
        {
            var result = DbContext.Update(entity);
            await DbContext.SaveChangesAsync();

            return result.Entity;
        }
    }
}
