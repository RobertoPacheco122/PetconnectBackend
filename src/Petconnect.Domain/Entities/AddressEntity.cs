﻿using System.Text.Json.Serialization;

namespace Petconnect.Domain.Entities;

public class AddressEntity : BaseEntity {
    public string Address { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public string? Complement { get; set; }
    public string District { get; set; } = string.Empty;
    public string CEP { get; set; } = string.Empty;
    public string ReceiverName { get; set; } = string.Empty;

    public CommonUserEntity? CommonUser { get; set; }
    public Guid? CommonUserId { get; set; }
    [JsonIgnore]
    public ServiceProviderEntity? ServiceProvider { get; set; }
    public Guid? ServiceProviderId { get; set; }
}

