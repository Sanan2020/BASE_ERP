using Microsoft.AspNetCore.Mvc;

namespace BASE_ERP.Controllers
{
    public class MobileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MenuERP()
        {
            return View();
        }
    }
}
