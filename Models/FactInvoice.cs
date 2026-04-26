using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class FactInvoice
{
    public int MoveId { get; set; }

    public int? PartnerId { get; set; }

    public int? CompanyId { get; set; }

    public int? JournalId { get; set; }

    public string? MoveType { get; set; }

    public string? State { get; set; }

    public string? PaymentState { get; set; }

    public DateOnly? MoveDate { get; set; }

    public DateOnly? InvoiceDate { get; set; }

    public DateOnly? DueDate { get; set; }

    public decimal? AmountUntaxed { get; set; }

    public decimal? AmountTax { get; set; }

    public decimal? AmountTotal { get; set; }

    public decimal? AmountResidual { get; set; }

    public string? InvoiceStatus { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual DimCompany? Company { get; set; }

    public virtual DimDate? DueDateNavigation { get; set; }

    public virtual DimDate? InvoiceDateNavigation { get; set; }

    public virtual DimJournal? Journal { get; set; }

    public virtual DimDate? MoveDateNavigation { get; set; }

    public virtual DimPartner? Partner { get; set; }
}
