using Petconnect.Domain.Enums;

namespace Petconnect.Domain.Entities;

public class EvaluationEntity : BaseEntity {
    public EEvaluate Evaluate { get; set; }
    public string? Opinion { get; set; }

    public ServiceEntity? Service { get; set; }
    public Guid ServiceId { get; set; }
}
