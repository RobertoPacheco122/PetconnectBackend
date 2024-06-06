using Petconnect.Domain.Entities;

namespace Petconnect.Domain.Interfaces.Services; 
public interface IMessageService {
    Task<bool> Delete(Guid id);
    Task<bool> ExistAsync(Guid id);
    Task<List<MessageEntity>> GetAll();
    Task<MessageEntity> GetSingle(Guid id);
    Task<MessageEntity> Insert(MessageEntity messageEntity);
    Task<MessageEntity> Update(MessageEntity messageEntity);
}
