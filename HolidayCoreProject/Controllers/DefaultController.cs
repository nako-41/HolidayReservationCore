using Microsoft.AspNetCore.Mvc;

namespace HolidayCoreProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
