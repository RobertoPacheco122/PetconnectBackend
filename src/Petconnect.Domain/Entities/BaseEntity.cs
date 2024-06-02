namespace Petconnect.Domain.Entities;

public class BaseEntity {
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public Guid? UserWhoLastUpdatedId { get; set; }
    public bool IsDeleted { get; set; } = false;
}
