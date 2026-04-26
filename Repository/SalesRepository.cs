using Microsoft.EntityFrameworkCore;
using Smart_ERP_System.Models;

namespace Smart_ERP_System.Repository
{
    public class SalesRepository : ISalesRepository
    {
        public AppDbContext Context { get; }
        public SalesRepository(AppDbContext context) {
            Context = context;
        }

        public IEnumerable<FactSale> getAll()
        {
            return Context.FactSales.ToList();
        }

        public FactSale getOrder(int id)
        {
            return Context.FactSales.FirstOrDefault(s => s.OrderId == id);
        }

        public IEnumerable<FactSale> getAllIncludingPartner()
        {
            return Context.FactSales.Include(s => s.Customer);
        }
    }
}
