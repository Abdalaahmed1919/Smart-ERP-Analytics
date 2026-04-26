using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class FactCrmPipeline
{
    public int LeadKey { get; set; }

    public int? StageKey { get; set; }

    public int? TeamKey { get; set; }

    public int? CampaignKey { get; set; }

    public int? LostReasonKey { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public DateOnly? UpdatedDate { get; set; }

    public decimal? ExpectedRevenue { get; set; }

    public decimal? Probability { get; set; }

    public bool? IsWon { get; set; }

    public bool? IsLost { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual DimCampaign? CampaignKeyNavigation { get; set; }

    public virtual DimLead LeadKeyNavigation { get; set; } = null!;

    public virtual DimLostReason? LostReasonKeyNavigation { get; set; }

    public virtual DimStage? StageKeyNavigation { get; set; }

    public virtual DimTeam? TeamKeyNavigation { get; set; }
}
