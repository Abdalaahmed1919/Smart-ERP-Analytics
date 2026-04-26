using Smart_ERP_System.Repository;
using Smart_ERP_System.ViewModel;

namespace Smart_ERP_System.Service
{
    public class SalesService : ISalesService
    {
        public ISalesRepository SalesRepository { get; }
        public SalesService(ISalesRepository salesRepository)
        {
            SalesRepository = salesRepository;
        }
        public List<MonthlySalesViewModel> GetLast5MonthsSales()
        {
            var salesData = SalesRepository.getAll().Where(x => x.CreatedAt.HasValue)
            .ToList();

            var months = Enumerable.Range(0, 5)
                .Select(i => DateTime.Now.AddMonths(-i))
                .Select(d => new { d.Year, d.Month })
                .OrderBy(x => x.Year)
                .ThenBy(x => x.Month)
                .ToList();

            var groupedSales = salesData
                    .GroupBy(x => new
                    {
                        Year = x.CreatedAt.Value.Year,
                        Month = x.CreatedAt.Value.Month
                    }).Select(g => new
                {
                    g.Key.Year,
                    g.Key.Month,
                    Total = g.Sum(x => x.PriceTotal)
                })
                .ToList();

            var result = months
                .Select(m => new MonthlySalesViewModel
                {
                    Year = m.Year,
                    Month = m.Month,
                    MonthName = new DateTime(m.Year, m.Month, 1).ToString("MMMM"),
                    TotalSales = groupedSales
                        .FirstOrDefault(g => g.Year == m.Year && g.Month == m.Month)?.Total ?? 0
                })
                .ToList();

            return result;
        }

        public salesViewModel GetSalesSummary()
        {
            var salesData = SalesRepository.getAll().ToList();
            var partners = SalesRepository.getAllIncludingPartner();
            var model = new salesViewModel
            {
                factSales = partners,
                TotalSales = salesData.Sum(x => x.PriceTotal) ?? 0,
                ActiveCustomer = salesData.GroupBy(x => x.CustomerId).Where(g => g.Count() > 1).Count(),
                OrdersLastMonth = salesData.Where(x => x.CreatedAt >= DateOnly.FromDateTime(DateTime.Now.AddDays(-30))).Count(),
                AvergeOrderValue = Math.Round(salesData.Average(o => o.PriceTotal) ?? 0, 2),
                Last5Months = GetLast5MonthsSales()
            };

                                return model;
        }
    }
}
