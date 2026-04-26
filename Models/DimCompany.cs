using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class DimCompany
{
    public int CompanyId { get; set; }

    public string? FirstSeenSource { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual ICollection<FactGlTransaction> FactGlTransactions { get; set; } = new List<FactGlTransaction>();

    public virtual ICollection<FactInvoice> FactInvoices { get; set; } = new List<FactInvoice>();

    public virtual ICollection<FactPurchaseOrder> FactPurchaseOrders { get; set; } = new List<FactPurchaseOrder>();
}
