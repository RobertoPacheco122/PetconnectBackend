using Petconnect.Domain.Entities;

namespace Petconnect.Domain.Interfaces.Services; 
public interface IServiceService {
    Task<bool> Delete(Guid id);
    Task<bool> ExistAsync(Guid id);
    Task<List<ServiceEntity>> GetAll();
    Task<ServiceEntity> GetSingle(Guid id);
    Task<ServiceEntity> Insert(ServiceEntity serviceEntity);
    Task<ServiceEntity> Update(ServiceEntity serviceEntity);
}
