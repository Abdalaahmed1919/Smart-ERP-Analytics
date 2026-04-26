using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class FactPurchaseOrder
{
    public int PurchaseOrderLineId { get; set; }

    public int? PurchaseOrderId { get; set; }

    public int? SupplierId { get; set; }

    public int? CompanyId { get; set; }

    public int? PickingTypeId { get; set; }

    public int? OrderUserId { get; set; }

    public int? ProductId { get; set; }

    public int? ProductUomId { get; set; }

    public string? OrderState { get; set; }

    public string? InvoiceStatus { get; set; }

    public decimal? AmountUntaxed { get; set; }

    public decimal? AmountTax { get; set; }

    public decimal? AmountTotal { get; set; }

    public decimal? ProductQty { get; set; }

    public decimal? ProductUomQty { get; set; }

    public decimal? PriceUnit { get; set; }

    public decimal? PriceSubtotal { get; set; }

    public decimal? PriceTotal { get; set; }

    public decimal? QtyInvoiced { get; set; }

    public decimal? QtyReceived { get; set; }

    public decimal? QtyToInvoice { get; set; }

    public decimal? Discount { get; set; }

    public string? LineDescription { get; set; }

    public DateOnly? OrderDate { get; set; }

    public DateOnly? DateApprove { get; set; }

    public DateOnly? DatePlanned { get; set; }

    public DateTime? OrderCreatedAt { get; set; }

    public DateTime? OrderUpdatedAt { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual DimCompany? Company { get; set; }

    public virtual DimDate? DateApproveNavigation { get; set; }

    public virtual DimDate? DatePlannedNavigation { get; set; }

    public virtual DimDate? OrderDateNavigation { get; set; }

    public virtual DimProduct? Product { get; set; }

    public virtual DimPartner? Supplier { get; set; }
}
