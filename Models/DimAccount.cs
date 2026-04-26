using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class DimAccount
{
    public int AccountId { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public string? AccountType { get; set; }

    public string? AccountCategory { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsReconcilable { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual ICollection<FactGlTransaction> FactGlTransactions { get; set; } = new List<FactGlTransaction>();
}
