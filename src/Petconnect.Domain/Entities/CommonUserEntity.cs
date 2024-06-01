namespace Petconnect.Domain.Entities;

public class CommonUserEntity : BaseEntity {
    public string Name { get; set; } = string.Empty;
    public string Cellphone { get; set; } = string.Empty;
    public string CPF { get; set; } = string.Empty;

    public List<AddressEntity>? Addresses { get; set; }
}
