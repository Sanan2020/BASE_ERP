using Microsoft.AspNetCore.Mvc;

namespace BASE_ERP.Controllers
{
    public class EmployeeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Index()
        {
            //return Content("ข้อมูลพนักงานทั้งหมด");
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Details()
        {
            return Content("รายละเอียดข้อมูล");
        }
        public IActionResult ShowSalary(int id)
        {
            return Content($"พนักงานรหัส: {id} มีเงินเดือน 20,000 บาท");
        }
    }
}
