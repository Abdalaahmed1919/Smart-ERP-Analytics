using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class DimLostReason
{
    public int LostReasonKey { get; set; }

    public int? LostReasonId { get; set; }

    public string? LostReasonName { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual ICollection<FactCrmPipeline> FactCrmPipelines { get; set; } = new List<FactCrmPipeline>();
}
