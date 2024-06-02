namespace Petconnect.Domain.Entities;

public class MessageEntity : BaseEntity {
    public string Message { get; set; } = string.Empty;
    public bool WasRead { get; set; }
    public DateTime SentDate { get; set; }
    public Guid SentFrom { get; set; }
    public Guid SentTo { get; set; }

    public ChatEntity? Chat { get; set; }
    public Guid ChatId { get; set; }
}
