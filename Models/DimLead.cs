using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class DimLead
{
    public int LeadKey { get; set; }

    public int? LeadId { get; set; }

    public string? LeadName { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual FactCrmPipeline? FactCrmPipeline { get; set; }
}
