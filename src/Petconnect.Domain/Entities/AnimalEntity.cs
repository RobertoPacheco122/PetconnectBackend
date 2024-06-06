namespace Petconnect.Domain.Entities;

public class AnimalEntity : BaseEntity {
    public string Name { get; set; } = string.Empty;

    public SpecieEntity? Specie { get; set; }
    public Guid SpecieId { get; set; }
    public List<ServiceEntity>? Services { get; set; }
}
