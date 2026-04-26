namespace Smart_ERP_System.Service
{
    public interface ISalesService
    {
        List<MonthlySalesViewModel> GetLast5MonthsSales();
        salesViewModel GetSalesSummary();

    }
}
