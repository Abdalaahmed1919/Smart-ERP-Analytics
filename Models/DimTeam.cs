using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class DimTeam
{
    public int TeamKey { get; set; }

    public int? TeamId { get; set; }

    public string? TeamName { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual ICollection<FactCrmPipeline> FactCrmPipelines { get; set; } = new List<FactCrmPipeline>();
}
