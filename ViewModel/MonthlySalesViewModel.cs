namespace Smart_ERP_System.ViewModel
{
    public class MonthlySalesViewModel
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public string MonthName { get; set; }
        public decimal ? TotalSales { get; set; }
    }
}
