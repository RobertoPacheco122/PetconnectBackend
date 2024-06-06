using Petconnect.Domain.Entities;

namespace Petconnect.Domain.Interfaces.Services; 
public interface IServiceRequestService {
    Task<bool> Delete(Guid id);
    Task<bool> ExistAsync(Guid id);
    Task<List<ServiceRequestEntity>> GetAll();
    Task<ServiceRequestEntity> GetSingle(Guid id);
    Task<ServiceRequestEntity> Insert(ServiceRequestEntity serviceRequestEntity);
    Task<ServiceRequestEntity> Update(ServiceRequestEntity serviceRequestEntity);
}
