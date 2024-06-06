using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Repositories;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.Application.Services;
public class ServiceCategoryService : IServiceCategoryService {
    private readonly IRepository<ServiceCategoryEntity> _serviceCategoryRepository;
    public ServiceCategoryService(IRepository<ServiceCategoryEntity> serviceCategoryRepository) {
        _serviceCategoryRepository = serviceCategoryRepository;
    }

    public async Task<bool> Delete(Guid id) {
        var deleteResult = await _serviceCategoryRepository.DeleteAsync(id);

        return deleteResult;
    }

    public Task<bool> ExistAsync(Guid id) {
        var queryResult = _serviceCategoryRepository.ExistAsync(id);

        return queryResult;
    }

    public Task<List<ServiceCategoryEntity>> GetAll() {
        var queryResult = _serviceCategoryRepository.GetAllAsync();

        return queryResult;
    }

    public Task<ServiceCategoryEntity> GetSingle(Guid id) {
        var queryResult = _serviceCategoryRepository.SelectAsync(id);

        return queryResult;
    }

    public Task<ServiceCategoryEntity> Insert(ServiceCategoryEntity serviceCategoryEntity) {
        var insertResult = _serviceCategoryRepository.InsertAsync(serviceCategoryEntity);

        return insertResult;
    }

    public Task<ServiceCategoryEntity> Update(ServiceCategoryEntity serviceCategoryEntity) {
        var updateResult = _serviceCategoryRepository.UpdateAsync(serviceCategoryEntity);

        return updateResult;
    }
}
