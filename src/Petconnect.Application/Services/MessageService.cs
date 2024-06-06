using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Repositories;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.Application.Services;
public class MessageService : IMessageService {
    private readonly IRepository<MessageEntity> _messageRepository;
    public MessageService(IRepository<MessageEntity> messageRepository) {
        _messageRepository = messageRepository;
    }

    public async Task<bool> Delete(Guid id) {
        var deleteResult = await _messageRepository.DeleteAsync(id);

        return deleteResult;
    }

    public Task<bool> ExistAsync(Guid id) {
        var queryResult = _messageRepository.ExistAsync(id);

        return queryResult;
    }

    public Task<List<MessageEntity>> GetAll() {
        var queryResult = _messageRepository.GetAllAsync();

        return queryResult;
    }

    public Task<MessageEntity> GetSingle(Guid id) {
        var queryResult = _messageRepository.SelectAsync(id);

        return queryResult;
    }

    public Task<MessageEntity> Insert(MessageEntity messageEntity) {
        var insertResult = _messageRepository.InsertAsync(messageEntity);

        return insertResult;
    }

    public Task<MessageEntity> Update(MessageEntity messageEntity) {
        var updateResult = _messageRepository.UpdateAsync(messageEntity);

        return updateResult;
    }
}
