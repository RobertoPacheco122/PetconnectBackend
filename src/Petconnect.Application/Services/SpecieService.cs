using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Repositories;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.Application.Services;
public class SpecieService : ISpecieService {
    private readonly IRepository<SpecieEntity> _specieRepository;
    public SpecieService(IRepository<SpecieEntity> specieRepository) {
        _specieRepository = specieRepository;
    }

    public async Task<bool> Delete(Guid id) {
        var deleteResult = await _specieRepository.DeleteAsync(id);

        return deleteResult;
    }

    public Task<bool> ExistAsync(Guid id) {
        var queryResult = _specieRepository.ExistAsync(id);

        return queryResult;
    }

    public Task<List<SpecieEntity>> GetAll() {
        var queryResult = _specieRepository.GetAllAsync();

        return queryResult;
    }

    public Task<SpecieEntity> GetSingle(Guid id) {
        var queryResult = _specieRepository.SelectAsync(id);

        return queryResult;
    }

    public Task<SpecieEntity> Insert(SpecieEntity specieEntity) {
        var insertResult = _specieRepository.InsertAsync(specieEntity);

        return insertResult;
    }

    public Task<SpecieEntity> Update(SpecieEntity specieEntity) {
        var updateResult = _specieRepository.UpdateAsync(specieEntity);

        return updateResult;
    }
}
