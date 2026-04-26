using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class DimJournal
{
    public int JournalId { get; set; }

    public int? CompanyId { get; set; }

    public string? JournalCode { get; set; }

    public string? JournalName { get; set; }

    public string? JournalType { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual ICollection<FactGlTransaction> FactGlTransactions { get; set; } = new List<FactGlTransaction>();

    public virtual ICollection<FactInvoice> FactInvoices { get; set; } = new List<FactInvoice>();
}
