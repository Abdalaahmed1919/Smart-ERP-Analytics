using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class DimDate
{
    public DateOnly FullDate { get; set; }

    public int YearNumber { get; set; }

    public int QuarterNumber { get; set; }

    public int MonthNumber { get; set; }

    public string MonthName { get; set; } = null!;

    public int DayOfWeek { get; set; }

    public string DayName { get; set; } = null!;

    public int DayOfMonth { get; set; }

    public int WeekOfYear { get; set; }

    public bool IsWeekend { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<FactEmployeeSnapshot> FactEmployeeSnapshots { get; set; } = new List<FactEmployeeSnapshot>();

    public virtual ICollection<FactGlTransaction> FactGlTransactions { get; set; } = new List<FactGlTransaction>();

    public virtual ICollection<FactInventoryMovement> FactInventoryMovements { get; set; } = new List<FactInventoryMovement>();

    public virtual ICollection<FactInventorySnapshot> FactInventorySnapshots { get; set; } = new List<FactInventorySnapshot>();

    public virtual ICollection<FactInvoice> FactInvoiceDueDateNavigations { get; set; } = new List<FactInvoice>();

    public virtual ICollection<FactInvoice> FactInvoiceInvoiceDateNavigations { get; set; } = new List<FactInvoice>();

    public virtual ICollection<FactInvoice> FactInvoiceMoveDateNavigations { get; set; } = new List<FactInvoice>();

    public virtual ICollection<FactPurchaseOrder> FactPurchaseOrderDateApproveNavigations { get; set; } = new List<FactPurchaseOrder>();

    public virtual ICollection<FactPurchaseOrder> FactPurchaseOrderDatePlannedNavigations { get; set; } = new List<FactPurchaseOrder>();

    public virtual ICollection<FactPurchaseOrder> FactPurchaseOrderOrderDateNavigations { get; set; } = new List<FactPurchaseOrder>();

    public virtual ICollection<FactSale> FactSales { get; set; } = new List<FactSale>();
}
