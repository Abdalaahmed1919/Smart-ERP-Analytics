using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class DimWarehouse
{
    public int WarehouseId { get; set; }

    public int? CompanyId { get; set; }

    public string? WarehouseName { get; set; }

    public string? WarehouseCode { get; set; }

    public string? ReceptionSteps { get; set; }

    public string? DeliverySteps { get; set; }

    public bool? IsActive { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual ICollection<FactInventoryMovement> FactInventoryMovements { get; set; } = new List<FactInventoryMovement>();

    public virtual ICollection<FactInventorySnapshot> FactInventorySnapshots { get; set; } = new List<FactInventorySnapshot>();
}
