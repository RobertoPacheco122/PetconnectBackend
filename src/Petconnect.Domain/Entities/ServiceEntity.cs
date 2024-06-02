namespace Petconnect.Domain.Entities;

public class ServiceEntity : BaseEntity {
    public string Description { get; set; } = string.Empty;
    public string BriefDescription { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
    public float BasePrice { get; set; }
    public bool IsVisible { get; set; } = false;

    public ServiceProviderEntity? ServiceProvider { get; set; }
    public Guid ServiceProviderId { get; set; }
    public ServiceCategoryEntity? ServiceCategory { get; set; }
    public Guid ServiceCategoryId { get; set; }
    public List<AnimalEntity>? ServiceFor { get; set; }
    public List<EvaluationEntity>? Evaluations { get; set; }
}
