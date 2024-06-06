using Petconnect.Domain.Entities;

namespace Petconnect.Domain.Interfaces.Services; 
public interface IAnimalService {
    Task<bool> Delete(Guid id);
    Task<bool> ExistAsync(Guid id);
    Task<List<AnimalEntity>> GetAll();
    Task<AnimalEntity> GetSingle(Guid id);
    Task<AnimalEntity> Insert(AnimalEntity animalEntity);
    Task<AnimalEntity> Update(AnimalEntity animalEntity);
}
