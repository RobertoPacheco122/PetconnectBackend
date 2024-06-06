using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Repositories;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.Application.Services;
public class UserService : IUserService {
    private readonly IRepository<UserEntity> _userRepository;
    public UserService(IRepository<UserEntity> userRepository) {
        _userRepository = userRepository;
    }

    public async Task<bool> Delete(Guid id) {
        var deleteResult = await _userRepository.DeleteAsync(id);

        return deleteResult;
    }

    public Task<bool> ExistAsync(Guid id) {
        var queryResult = _userRepository.ExistAsync(id);

        return queryResult;
    }

    public Task<List<UserEntity>> GetAll() {
        var queryResult = _userRepository.GetAllAsync();

        return queryResult;
    }

    public Task<UserEntity> GetSingle(Guid id) {
        var queryResult = _userRepository.SelectAsync(id);

        return queryResult;
    }

    public Task<UserEntity> Insert(UserEntity userEntity) {
        var insertResult = _userRepository.InsertAsync(userEntity);

        return insertResult;
    }

    public Task<UserEntity> Update(UserEntity userEntity) {
        var updateResult = _userRepository.UpdateAsync(userEntity);

        return updateResult;
    }
}
