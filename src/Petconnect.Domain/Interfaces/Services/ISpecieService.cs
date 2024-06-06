using Petconnect.Domain.Entities;

namespace Petconnect.Domain.Interfaces.Services; 
public interface ISpecieService {
    Task<bool> Delete(Guid id);
    Task<bool> ExistAsync(Guid id);
    Task<List<SpecieEntity>> GetAll();
    Task<SpecieEntity> GetSingle(Guid id);
    Task<SpecieEntity> Insert(SpecieEntity specieEntity);
    Task<SpecieEntity> Update(SpecieEntity specieEntity);
}
