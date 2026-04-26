using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class FactInventorySnapshot
{
    public int StockQuantId { get; set; }

    public int? ProductId { get; set; }

    public int? WarehouseId { get; set; }

    public int? LocationId { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? ReservedQuantity { get; set; }

    public decimal? AvailableQuantity { get; set; }

    public DateOnly? InventoryDate { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual DimDate? InventoryDateNavigation { get; set; }

    public virtual DimInventory? Location { get; set; }

    public virtual DimProduct? Product { get; set; }

    public virtual DimWarehouse? Warehouse { get; set; }
}
