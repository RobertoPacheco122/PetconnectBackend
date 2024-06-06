using Petconnect.Domain.Entities;

namespace Petconnect.Domain.Interfaces.Services;
public interface IAddressService {
    Task<bool> Delete(Guid id);
    Task<bool> ExistAsync(Guid id);
    Task<List<AddressEntity>> GetAll();
    Task<AddressEntity> GetSingle(Guid id);
    Task<AddressEntity> Insert(AddressEntity addressEntity);
    Task<AddressEntity> Update(AddressEntity addressEntity);
}
