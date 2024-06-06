using Petconnect.Domain.Entities;

namespace Petconnect.Domain.Interfaces.Services; 
public interface ICommonUserService {
    Task<bool> Delete(Guid id);
    Task<bool> ExistAsync(Guid id);
    Task<List<CommonUserEntity>> GetAll();
    Task<CommonUserEntity> GetSingle(Guid id);
    Task<CommonUserEntity> Insert(CommonUserEntity commonUserEntity);
    Task<CommonUserEntity> Update(CommonUserEntity commonUserEntity);
}
