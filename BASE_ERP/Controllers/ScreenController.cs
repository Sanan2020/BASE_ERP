using Microsoft.AspNetCore.Mvc;

namespace BASE_ERP.Controllers
{
    public class ScreenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
