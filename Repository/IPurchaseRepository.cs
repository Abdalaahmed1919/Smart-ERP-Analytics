using Smart_ERP_System.Models;

namespace Smart_ERP_System.Repository
{
    public interface IPurchaseRepository
    {
        IEnumerable<FactPurchaseOrder> GetAll();
        IEnumerable<FactPurchaseOrder> GetAllIncludingPartner();
        FactPurchaseOrder GetById(int id);
    }
}
