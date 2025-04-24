using Microsoft.AspNetCore.Mvc;

namespace BASE_ERP.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}
