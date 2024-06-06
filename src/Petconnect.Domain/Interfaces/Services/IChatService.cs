using Petconnect.Domain.Entities;

namespace Petconnect.Domain.Interfaces.Services; 
public interface IChatService {
    Task<bool> Delete(Guid id);
    Task<bool> ExistAsync(Guid id);
    Task<List<ChatEntity>> GetAll();
    Task<ChatEntity> GetSingle(Guid id);
    Task<ChatEntity> Insert(ChatEntity chatEntity);
    Task<ChatEntity> Update(ChatEntity chatEntity);
}
