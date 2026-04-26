namespace Smart_ERP_System.Service
{
    public interface IPurchaseService
    {
        List<MonthlySalesViewModel> GetLast5MonthsPurchase();
        PurchaseViewModel GetPurchaseSummary();
    }
}
