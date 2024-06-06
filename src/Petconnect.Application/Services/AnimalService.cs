using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Repositories;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.Application.Services;
public class AnimalService : IAnimalService {
    private readonly IRepository<AnimalEntity> _animalRepository;
    public AnimalService(IRepository<AnimalEntity> animalRepository) {
        _animalRepository = animalRepository;
    }

    public async Task<bool> Delete(Guid id) {
        var deleteResult = await _animalRepository.DeleteAsync(id);

        return deleteResult;
    }

    public Task<bool> ExistAsync(Guid id) {
        var queryResult = _animalRepository.ExistAsync(id);

        return queryResult;
    }

    public Task<List<AnimalEntity>> GetAll() {
        var queryResult = _animalRepository.GetAllAsync();

        return queryResult;
    }

    public Task<AnimalEntity> GetSingle(Guid id) {
        var queryResult = _animalRepository.SelectAsync(id);

        return queryResult;
    }

    public Task<AnimalEntity> Insert(AnimalEntity animalEntity) {
        var insertResult = _animalRepository.InsertAsync(animalEntity);

        return insertResult;
    }

    public Task<AnimalEntity> Update(AnimalEntity animalEntity) {
        var updateResult = _animalRepository.UpdateAsync(animalEntity);

        return updateResult;
    }
}
