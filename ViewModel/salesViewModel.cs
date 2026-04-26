using Smart_ERP_System.Models;
using System.Numerics;

namespace Smart_ERP_System.ViewModel
{
    public class salesViewModel
    {
        public IEnumerable<FactSale> factSales { get; set; }
        public decimal TotalSales { get; set; }
        public int ActiveCustomer {  get; set; }

        public int OrdersLastMonth { get; set; }
        public decimal AvergeOrderValue { get; set; }
        public List<MonthlySalesViewModel> Last5Months { get; set; }

    }
}
