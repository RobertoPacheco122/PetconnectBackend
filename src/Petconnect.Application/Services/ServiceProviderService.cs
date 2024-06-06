using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Repositories;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.Application.Services;
public class ServiceProviderService : IServiceProviderService {
    private readonly IRepository<ServiceProviderEntity> _serviceProviderRepository;
    public ServiceProviderService(IRepository<ServiceProviderEntity> serviceProviderRepository) {
        _serviceProviderRepository = serviceProviderRepository;
    }

    public async Task<bool> Delete(Guid id) {
        var deleteResult = await _serviceProviderRepository.DeleteAsync(id);

        return deleteResult;
    }

    public Task<bool> ExistAsync(Guid id) {
        var queryResult = _serviceProviderRepository.ExistAsync(id);

        return queryResult;
    }

    public Task<List<ServiceProviderEntity>> GetAll() {
        var queryResult = _serviceProviderRepository.GetAllAsync();

        return queryResult;
    }

    public Task<ServiceProviderEntity> GetSingle(Guid id) {
        var queryResult = _serviceProviderRepository.SelectAsync(id);

        return queryResult;
    }

    public Task<ServiceProviderEntity> Insert(ServiceProviderEntity serviceProviderEntity) {
        var insertResult = _serviceProviderRepository.InsertAsync(serviceProviderEntity);

        return insertResult;
    }

    public Task<ServiceProviderEntity> Update(ServiceProviderEntity serviceProviderEntity) {
        var updateResult = _serviceProviderRepository.UpdateAsync(serviceProviderEntity);

        return updateResult;
    }
}
