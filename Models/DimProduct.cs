using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class DimProduct
{
    public int ProductId { get; set; }

    public int? CategId { get; set; }

    public string? ProductSku { get; set; }

    public string? ProductName { get; set; }

    public string? ProductType { get; set; }

    public string? ProductStatus { get; set; }

    public decimal? ProductListPrice { get; set; }

    public decimal? ProductCost { get; set; }

    public decimal? ProductGrossMarginEstimated { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Volume { get; set; }

    public bool? SaleOk { get; set; }

    public bool? PurchaseOk { get; set; }

    public string? CategName { get; set; }

    public string? CategoryFullName { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual ICollection<DimProductCombo> DimProductCombos { get; set; } = new List<DimProductCombo>();

    public virtual ICollection<DimProductPricelist> DimProductPricelists { get; set; } = new List<DimProductPricelist>();

    public virtual ICollection<FactGlTransaction> FactGlTransactions { get; set; } = new List<FactGlTransaction>();

    public virtual ICollection<FactInventoryMovement> FactInventoryMovements { get; set; } = new List<FactInventoryMovement>();

    public virtual ICollection<FactInventorySnapshot> FactInventorySnapshots { get; set; } = new List<FactInventorySnapshot>();

    public virtual ICollection<FactPurchaseOrder> FactPurchaseOrders { get; set; } = new List<FactPurchaseOrder>();

    public virtual ICollection<FactSale> FactSales { get; set; } = new List<FactSale>();
}
