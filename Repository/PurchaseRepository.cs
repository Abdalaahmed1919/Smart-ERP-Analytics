using Microsoft.EntityFrameworkCore;
using Smart_ERP_System.Models;

namespace Smart_ERP_System.Repository
{
    public class PurchaseRepository : IPurchaseRepository
    {

        public AppDbContext Context { get; }
        public PurchaseRepository(AppDbContext context)
        {
            Context = context;
        }


        public FactPurchaseOrder GetById(int id)
        {
            return Context.FactPurchaseOrders.FirstOrDefault(O => O.PurchaseOrderLineId == id);
        }

        public IEnumerable<FactPurchaseOrder> GetAll()
        {
            return Context.FactPurchaseOrders.ToList();
        }

        public IEnumerable<FactPurchaseOrder> GetAllIncludingPartner()
        {
            return Context.FactPurchaseOrders.Include(p => p.Supplier).ToList();
        }

        //public IEnumerable<FactPurchaseOrder> GetAllIncludingPartner()
        //{
        //    return Context.FactPurchaseOrders.Include(p => )
        //}
    }
}
