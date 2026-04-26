using Smart_ERP_System.Models;

namespace Smart_ERP_System.ViewModel
{
    public class PurchaseViewModel
    {
        public IEnumerable<FactPurchaseOrder> Purchase { get; set; } = new List<FactPurchaseOrder>();
        public int TotalOrders { get; set; }
        public decimal TotalSpend { get; set; }
        public int ActiveSuppliers  { get; set; }
        public int PendingApprovals { get; set; }
        public List<MonthlySalesViewModel> MonthlySalesView { get; set; }
    }
}
