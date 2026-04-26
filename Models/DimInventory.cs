using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class DimInventory
{
    public int LocationId { get; set; }

    public int? WarehouseId { get; set; }

    public string? LocationName { get; set; }

    public string? WarehouseName { get; set; }

    public string? LocationPath { get; set; }

    public string? LocationType { get; set; }

    public bool? IsActive { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual ICollection<FactInventoryMovement> FactInventoryMovementFromLocations { get; set; } = new List<FactInventoryMovement>();

    public virtual ICollection<FactInventoryMovement> FactInventoryMovementToLocations { get; set; } = new List<FactInventoryMovement>();

    public virtual ICollection<FactInventorySnapshot> FactInventorySnapshots { get; set; } = new List<FactInventorySnapshot>();
}
