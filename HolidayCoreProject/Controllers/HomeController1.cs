using Microsoft.AspNetCore.Mvc;

namespace HolidayCoreProject.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
