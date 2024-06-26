using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Repositories;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.Application.Services;
public class ServiceService : IServiceService {
    private readonly IRepository<ServiceEntity> _serviceRepository;
    private readonly IServiceRepository _specificServiceRepository;

    public ServiceService(IRepository<ServiceEntity> serviceRepository, IServiceRepository specificServiceRepository) {
        _serviceRepository = serviceRepository;
        _specificServiceRepository = specificServiceRepository;
    }

    public async Task<bool> Delete(Guid id) {
        var deleteResult = await _serviceRepository.DeleteAsync(id);

        return deleteResult;
    }

    public Task<bool> ExistAsync(Guid id) {
        var queryResult = _serviceRepository.ExistAsync(id);

        return queryResult;
    }

    public Task<List<ServiceEntity>> GetAll() {
        var queryResult = _specificServiceRepository.GetAllRelatedDetails();

        return queryResult;
    }

    public Task<ServiceEntity> GetSingle(Guid id) {
        var queryResult = _specificServiceRepository.GetAllRelatedDetailsById(id);

        return queryResult;
    }

    public Task<ServiceEntity> Insert(ServiceEntity serviceEntity) {
        var insertResult = _serviceRepository.InsertAsync(serviceEntity);

        return insertResult;
    }

    public Task<ServiceEntity> Update(ServiceEntity serviceEntity) {
        var updateResult = _serviceRepository.UpdateAsync(serviceEntity);

        return updateResult;
    }
}
