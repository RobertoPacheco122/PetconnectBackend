using Petconnect.Domain.Entities;

namespace Petconnect.Domain.Interfaces.Services; 
public interface IUserService {
    Task<bool> Delete(Guid id);
    Task<bool> ExistAsync(Guid id);
    Task<List<UserEntity>> GetAll();
    Task<UserEntity> GetSingle(Guid id);
    Task<UserEntity> Insert(UserEntity userEntity);
    Task<UserEntity> Update(UserEntity userEntity);
}
