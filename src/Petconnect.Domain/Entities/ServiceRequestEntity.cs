using Petconnect.Domain.Enums;

namespace Petconnect.Domain.Entities;
public class ServiceRequestEntity : BaseEntity {
    public DateTime RequestDate { get; set; }
    public DateTime? ProvisionDate { get; set; }
    public EServiceRequestStatus RequestStatus { get; set; }

    public UserEntity? UserWhoRequested { get; set; }
    public Guid UserWhoRequestedId { get; set; }
    public ServiceEntity? Service { get; set; }
    public Guid ServiceId { get; set; }
    public ChatEntity? Chat { get; set; }
    public Guid ChatId { get; set; }
}
