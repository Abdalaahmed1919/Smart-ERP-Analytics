using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class FactGlTransaction
{
    public int MoveLineId { get; set; }

    public int? AccountId { get; set; }

    public int? JournalId { get; set; }

    public int? PartnerId { get; set; }

    public int? ProductId { get; set; }

    public int? CompanyId { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public DateOnly? MoveDate { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual DimAccount? Account { get; set; }

    public virtual DimCompany? Company { get; set; }

    public virtual DimJournal? Journal { get; set; }

    public virtual DimDate? MoveDateNavigation { get; set; }

    public virtual DimPartner? Partner { get; set; }

    public virtual DimProduct? Product { get; set; }
}
