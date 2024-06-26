﻿using Petconnect.Domain.Enums;
using System.Text.Json.Serialization;

namespace Petconnect.Domain.Entities;

public class EvaluationEntity : BaseEntity {
    public EEvaluate Evaluate { get; set; }
    public string? Opinion { get; set; }

    [JsonIgnore]
    public ServiceEntity? Service { get; set; }
    public Guid ServiceId { get; set; }
}
