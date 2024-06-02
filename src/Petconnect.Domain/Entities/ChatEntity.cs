namespace Petconnect.Domain.Entities;
public class ChatEntity : BaseEntity {
    public List<MessageEntity>? Messages { get; set; }

    public CommonUserEntity? CommonUser { get; set; }
    public Guid CommonUserId { get; set; }
    public ServiceProviderEntity? ServiceProvider { get; set; }
    public Guid ServiceProviderId { get; set; }
}
