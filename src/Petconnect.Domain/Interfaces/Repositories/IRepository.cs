using Petconnect.Domain.Entities;

namespace Petconnect.Domain.Interfaces.Repositories; 
public interface IRepository<T> where T : BaseEntity {
    Task<bool> DeleteAsync(Guid id);
    Task<bool> ExistAsync(Guid id);
    Task<List<T>> GetAllAsync();
    Task<T> InsertAsync(T entity);
    Task<T> SelectAsync(Guid id);
    Task<T> UpdateAsync(T entity);
}
