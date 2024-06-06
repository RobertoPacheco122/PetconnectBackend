using Petconnect.Domain.Entities;

namespace Petconnect.Domain.Interfaces.Services; 
public interface IEvaluationService {
    Task<bool> Delete(Guid id);
    Task<bool> ExistAsync(Guid id);
    Task<List<EvaluationEntity>> GetAll();
    Task<EvaluationEntity> GetSingle(Guid id);
    Task<EvaluationEntity> Insert(EvaluationEntity evaluationEntity);
    Task<EvaluationEntity> Update(EvaluationEntity evaluationEntity);
}
