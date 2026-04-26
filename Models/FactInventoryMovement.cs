using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class FactInventoryMovement
{
    public int StockMoveLineId { get; set; }

    public int? ProductId { get; set; }

    public int? WarehouseId { get; set; }

    public int? LotId { get; set; }

    public int? PickingId { get; set; }

    public int? FromLocationId { get; set; }

    public int? ToLocationId { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? MoveValue { get; set; }

    public string? LotName { get; set; }

    public string? PickingName { get; set; }

    public string? MoveState { get; set; }

    public string? PickingState { get; set; }

    public bool? IsIn { get; set; }

    public bool? IsOut { get; set; }

    public bool? IsInternal { get; set; }

    public DateOnly? MovementDate { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual DimInventory? FromLocation { get; set; }

    public virtual DimDate? MovementDateNavigation { get; set; }

    public virtual DimProduct? Product { get; set; }

    public virtual DimInventory? ToLocation { get; set; }

    public virtual DimWarehouse? Warehouse { get; set; }
}
