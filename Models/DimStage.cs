using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class DimStage
{
    public int StageKey { get; set; }

    public int? StageId { get; set; }

    public string? StageName { get; set; }

    public decimal? Probability { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual ICollection<FactCrmPipeline> FactCrmPipelines { get; set; } = new List<FactCrmPipeline>();
}
