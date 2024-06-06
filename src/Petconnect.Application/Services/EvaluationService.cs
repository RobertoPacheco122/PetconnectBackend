using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Repositories;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.Application.Services;
public class EvaluationService : IEvaluationService {
    private readonly IRepository<EvaluationEntity> _evaluationRepository;
    public EvaluationService(IRepository<EvaluationEntity> evaluationRepository) {
        _evaluationRepository = evaluationRepository;
    }

    public async Task<bool> Delete(Guid id) {
        var deleteResult = await _evaluationRepository.DeleteAsync(id);

        return deleteResult;
    }

    public Task<bool> ExistAsync(Guid id) {
        var queryResult = _evaluationRepository.ExistAsync(id);

        return queryResult;
    }

    public Task<List<EvaluationEntity>> GetAll() {
        var queryResult = _evaluationRepository.GetAllAsync();

        return queryResult;
    }

    public Task<EvaluationEntity> GetSingle(Guid id) {
        var queryResult = _evaluationRepository.SelectAsync(id);

        return queryResult;
    }

    public Task<EvaluationEntity> Insert(EvaluationEntity evaluationEntity) {
        var insertResult = _evaluationRepository.InsertAsync(evaluationEntity);

        return insertResult;
    }

    public Task<EvaluationEntity> Update(EvaluationEntity evaluationEntity) {
        var updateResult = _evaluationRepository.UpdateAsync(evaluationEntity);

        return updateResult;
    }
}
