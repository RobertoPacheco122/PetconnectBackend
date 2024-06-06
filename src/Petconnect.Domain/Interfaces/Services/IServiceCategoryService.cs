using Petconnect.Domain.Entities;

namespace Petconnect.Domain.Interfaces.Services; 
public interface IServiceCategoryService {
    Task<bool> Delete(Guid id);
    Task<bool> ExistAsync(Guid id);
    Task<List<ServiceCategoryEntity>> GetAll();
    Task<ServiceCategoryEntity> GetSingle(Guid id);
    Task<ServiceCategoryEntity> Insert(ServiceCategoryEntity serviceCategoryEntity);
    Task<ServiceCategoryEntity> Update(ServiceCategoryEntity serviceCategoryEntity);
}
