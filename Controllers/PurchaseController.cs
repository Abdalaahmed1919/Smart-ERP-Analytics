using Microsoft.AspNetCore.Mvc;
using Smart_ERP_System.Service;

namespace Smart_ERP_System.Controllers
{
    public class PurchaseController : Controller
    {

        public IPurchaseService PurchaseService { get; }
        public PurchaseController(IPurchaseService purchaseService)
        {
            PurchaseService = purchaseService;
        }


        public IActionResult Index()
        {
            var model = PurchaseService.GetPurchaseSummary();
            return View(model);
        }
    }
}
