using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class DimCampaign
{
    public int CampaignKey { get; set; }

    public int? CampaignId { get; set; }

    public string? CampaignName { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual ICollection<FactCrmPipeline> FactCrmPipelines { get; set; } = new List<FactCrmPipeline>();
}
