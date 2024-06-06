using Petconnect.Domain.Entities;

namespace Petconnect.Domain.Interfaces.Services; 
public interface IServiceProviderService {
    Task<bool> Delete(Guid id);
    Task<bool> ExistAsync(Guid id);
    Task<List<ServiceProviderEntity>> GetAll();
    Task<ServiceProviderEntity> GetSingle(Guid id);
    Task<ServiceProviderEntity> Insert(ServiceProviderEntity serviceProviderEntity);
    Task<ServiceProviderEntity> Update(ServiceProviderEntity serviceProviderEntity);
}
