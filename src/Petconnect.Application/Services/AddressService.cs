using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Repositories;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.Application.Services;
public class AddressService : IAddressService {
    private readonly IRepository<AddressEntity> _addressRepository;
    public AddressService(IRepository<AddressEntity> addressRepository) {
        _addressRepository = addressRepository;
    }

    public async Task<bool> Delete(Guid id) {
        var deleteResult = await _addressRepository.DeleteAsync(id);

        return deleteResult;
    }

    public Task<bool> ExistAsync(Guid id) {
        var queryResult = _addressRepository.ExistAsync(id);

        return queryResult;
    }

    public Task<List<AddressEntity>> GetAll() {
        var queryResult = _addressRepository.GetAllAsync();

        return queryResult;
    }

    public Task<AddressEntity> GetSingle(Guid id) {
        var queryResult = _addressRepository.SelectAsync(id);

        return queryResult;
    }

    public Task<AddressEntity> Insert(AddressEntity addressEntity) {
        var insertResult = _addressRepository.InsertAsync(addressEntity);

        return insertResult;
    }

    public Task<AddressEntity> Update(AddressEntity addressEntity) {
        var updateResult = _addressRepository.UpdateAsync(addressEntity);

        return updateResult;
    }
}
