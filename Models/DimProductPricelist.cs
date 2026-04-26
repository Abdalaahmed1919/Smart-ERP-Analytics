using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class DimProductPricelist
{
    public int PricelistItemId { get; set; }

    public int? PricelistId { get; set; }

    public int? CompanyId { get; set; }

    public int? ProductTmplId { get; set; }

    public int? ProductId { get; set; }

    public int? CategId { get; set; }

    public string? AppliedOn { get; set; }

    public string? ComputePrice { get; set; }

    public decimal? FixedPrice { get; set; }

    public decimal? PercentPrice { get; set; }

    public decimal? PriceDiscount { get; set; }

    public decimal? PriceSurcharge { get; set; }

    public decimal? PriceMarkup { get; set; }

    public decimal? PriceMinMargin { get; set; }

    public decimal? PriceMaxMargin { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual DimProduct? Product { get; set; }
}
