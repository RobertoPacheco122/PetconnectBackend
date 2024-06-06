using Petconnect.Domain.Entities;
using Petconnect.Domain.Interfaces.Repositories;
using Petconnect.Domain.Interfaces.Services;

namespace Petconnect.Application.Services;
public class ChatService : IChatService {
    private readonly IRepository<ChatEntity> _chatRepository;
    public ChatService(IRepository<ChatEntity> chatRepository) {
        _chatRepository = chatRepository;
    }

    public async Task<bool> Delete(Guid id) {
        var deleteResult = await _chatRepository.DeleteAsync(id);

        return deleteResult;
    }

    public Task<bool> ExistAsync(Guid id) {
        var queryResult = _chatRepository.ExistAsync(id);

        return queryResult;
    }

    public Task<List<ChatEntity>> GetAll() {
        var queryResult = _chatRepository.GetAllAsync();

        return queryResult;
    }

    public Task<ChatEntity> GetSingle(Guid id) {
        var queryResult = _chatRepository.SelectAsync(id);

        return queryResult;
    }

    public Task<ChatEntity> Insert(ChatEntity chatEntity) {
        var insertResult = _chatRepository.InsertAsync(chatEntity);

        return insertResult;
    }

    public Task<ChatEntity> Update(ChatEntity chatEntity) {
        var updateResult = _chatRepository.UpdateAsync(chatEntity);

        return updateResult;
    }
}
