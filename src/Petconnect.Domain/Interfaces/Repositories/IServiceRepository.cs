using Petconnect.Domain.Entities;

namespace Petconnect.Domain.Interfaces.Repositories; 
public interface IServiceRepository {
    Task<List<ServiceEntity>> GetAllRelatedDetails();
    Task<ServiceEntity> GetAllRelatedDetailsById(Guid id);
}
