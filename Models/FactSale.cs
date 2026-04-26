using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class FactSale
{
    public int SaleOrderLineId { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? CustomerId { get; set; }

    public string? OrderState { get; set; }

    public string? InvoiceStatus { get; set; }

    public DateOnly? OrderDate { get; set; }

    public decimal? ProductQty { get; set; }

    public decimal? PriceUnit { get; set; }

    public decimal? Discount { get; set; }

    public decimal? PriceSubtotal { get; set; }

    public decimal? PriceTotal { get; set; }

    public decimal? PriceTax { get; set; }

    public decimal? NetRevenue { get; set; }

    public decimal? GrossRevenue { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual DimPartner? Customer { get; set; }

    public virtual DimDate? OrderDateNavigation { get; set; }

    public virtual DimProduct? Product { get; set; }
}
