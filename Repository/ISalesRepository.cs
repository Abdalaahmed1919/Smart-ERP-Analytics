using Microsoft.AspNetCore.Razor.Language;
using Smart_ERP_System.Models;

namespace Smart_ERP_System.Repository
{
    public interface ISalesRepository
    {
        IEnumerable<FactSale> getAll();
        IEnumerable<FactSale> getAllIncludingPartner();
        FactSale getOrder(int id);


            
    }
}
