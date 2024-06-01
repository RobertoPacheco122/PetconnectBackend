namespace Petconnect.Domain.Entities;

public class UserEntity : BaseEntity {
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public DateOnly Birthdate { get; set; }

    public ServiceProviderEntity? ServiceProvider { get; set; }
    public Guid ServiceProviderId { get; set; }
    public CommonUserEntity? CommonUser { get; set; }
    public Guid CommonUserId { get; set; }
}
