using Smart_ERP_System.Repository;

namespace Smart_ERP_System.Service
{
    public class PurchaseService : IPurchaseService
    {
        public IPurchaseRepository PurchaseRepository { get; }
        public PurchaseService(IPurchaseRepository purchaseRepository)
        {
            PurchaseRepository = purchaseRepository;
        }

        public List<MonthlySalesViewModel> GetLast5MonthsPurchase()
        {
            var salesData = PurchaseRepository.GetAll().Where(x => x.OrderCreatedAt.HasValue)
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
                        Year = x.OrderCreatedAt.Value.Year,
                        Month = x.OrderCreatedAt.Value.Month
                    }).Select(g => new
                    {
                        g.Key.Year,
                        g.Key.Month,
                        Total = g.Sum(x => x.AmountTotal)
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
        public PurchaseViewModel  GetPurchaseSummary()
        {
            var Purchese = PurchaseRepository.GetAllIncludingPartner();
            var model = new PurchaseViewModel
            {
                Purchase = Purchese.DistinctBy(o => o.PurchaseOrderId),
                TotalOrders = Purchese.Select(x => x.PurchaseOrderId).Distinct().Count(),
                TotalSpend = Purchese.GroupBy(x => x.PurchaseOrderId)
                           .Select(g => g.First().AmountTotal).Sum() ?? 0,
                ActiveSuppliers = Purchese.Select(x => x.SupplierId).Distinct().Count(),
                PendingApprovals = Purchese.Where(x => x.OrderState == "draft" ||
                                  x.OrderState == "sent")
                                  .Select(x => x.PurchaseOrderId)
                                   .Distinct()
                                      .Count(),
                MonthlySalesView = GetLast5MonthsPurchase()
            };
            return model;
        }
    }
}
