using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Repositories;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.Application.Services;
public class CommonUserService : ICommonUserService {
    private readonly IRepository<CommonUserEntity> _commonUserRepository;
    public CommonUserService(IRepository<CommonUserEntity> commonUserRepository) {
        _commonUserRepository = commonUserRepository;
    }

    public async Task<bool> Delete(Guid id) {
        var deleteResult = await _commonUserRepository.DeleteAsync(id);

        return deleteResult;
    }

    public Task<bool> ExistAsync(Guid id) {
        var queryResult = _commonUserRepository.ExistAsync(id);

        return queryResult;
    }

    public Task<List<CommonUserEntity>> GetAll() {
        var queryResult = _commonUserRepository.GetAllAsync();

        return queryResult;
    }

    public Task<CommonUserEntity> GetSingle(Guid id) {
        var queryResult = _commonUserRepository.SelectAsync(id);

        return queryResult;
    }

    public Task<CommonUserEntity> Insert(CommonUserEntity commonUserEntity) {
        var insertResult = _commonUserRepository.InsertAsync(commonUserEntity);

        return insertResult;
    }

    public Task<CommonUserEntity> Update(CommonUserEntity commonUserEntity) {
        var updateResult = _commonUserRepository.UpdateAsync(commonUserEntity);

        return updateResult;
    }
}
