using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class DimProductCombo
{
    public int ComboItemId { get; set; }

    public int? ComboId { get; set; }

    public int? ProductId { get; set; }

    public int? CompanyId { get; set; }

    public string? ComboName { get; set; }

    public decimal? ExtraPrice { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual DimProduct? Product { get; set; }
}
