using Microsoft.AspNetCore.Mvc;
using Smart_ERP_System.Repository;
using Smart_ERP_System.Service;

namespace Smart_ERP_System.Controllers
{
    public class SalesController : Controller
    {
        public ISalesRepository SalesRepository { get; }
        public ISalesService SalesService { get; }

        public SalesController (ISalesRepository salesRepository , ISalesService salesService ) {
            SalesRepository = salesRepository;
            SalesService = salesService;
        }
        

        public IActionResult Index()
        {
            var model = SalesService.GetSalesSummary();
            return View(model);
        }
    }
}
