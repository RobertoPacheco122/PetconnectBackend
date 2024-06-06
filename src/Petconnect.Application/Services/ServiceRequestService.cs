using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Repositories;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.Application.Services;
public class ServiceRequestService : IServiceRequestService {
    private readonly IRepository<ServiceRequestEntity> _serviceRequestRepository;
    public ServiceRequestService(IRepository<ServiceRequestEntity> serviceRequestRepository) {
        _serviceRequestRepository = serviceRequestRepository;
    }

    public async Task<bool> Delete(Guid id) {
        var deleteResult = await _serviceRequestRepository.DeleteAsync(id);

        return deleteResult;
    }

    public Task<bool> ExistAsync(Guid id) {
        var queryResult = _serviceRequestRepository.ExistAsync(id);

        return queryResult;
    }

    public Task<List<ServiceRequestEntity>> GetAll() {
        var queryResult = _serviceRequestRepository.GetAllAsync();

        return queryResult;
    }

    public Task<ServiceRequestEntity> GetSingle(Guid id) {
        var queryResult = _serviceRequestRepository.SelectAsync(id);

        return queryResult;
    }

    public Task<ServiceRequestEntity> Insert(ServiceRequestEntity serviceRequestEntity) {
        var insertResult = _serviceRequestRepository.InsertAsync(serviceRequestEntity);

        return insertResult;
    }

    public Task<ServiceRequestEntity> Update(ServiceRequestEntity serviceRequestEntity) {
        var updateResult = _serviceRequestRepository.UpdateAsync(serviceRequestEntity);

        return updateResult;
    }
}
