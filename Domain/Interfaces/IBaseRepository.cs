using Domain.Models;

namespace Domain.Interfaces
{
    public interface IBaseRepository<TModel>
        where TModel : BaseModel
    {
        Task<TModel> CreateAsync(TModel entity);
        Task<TModel> DeleteAsync(Guid id);
        Task<IEnumerable<TModel>> GetAllAsync();
        Task<IEnumerable<TModel>> GetRangeAsync(ICollection<Guid> ids);
        Task<TModel> GetAsync(Guid id);
        Task<TModel> UpdateAsync(TModel entity);
    }
}
