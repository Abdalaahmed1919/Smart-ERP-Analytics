using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class DimPartner
{
    public int PartnerId { get; set; }

    public int? CompanyId { get; set; }

    public int? ParentId { get; set; }

    public int? CommercialPartnerId { get; set; }

    public int? CountryId { get; set; }

    public int? StateId { get; set; }

    public int? IndustryId { get; set; }

    public string? PartnerName { get; set; }

    public string? PartnerType { get; set; }

    public bool? IsCompany { get; set; }

    public bool? Active { get; set; }

    public int? CustomerRank { get; set; }

    public int? SupplierRank { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual ICollection<FactGlTransaction> FactGlTransactions { get; set; } = new List<FactGlTransaction>();

    public virtual ICollection<FactInvoice> FactInvoices { get; set; } = new List<FactInvoice>();

    public virtual ICollection<FactPurchaseOrder> FactPurchaseOrders { get; set; } = new List<FactPurchaseOrder>();

    public virtual ICollection<FactSale> FactSales { get; set; } = new List<FactSale>();
}
