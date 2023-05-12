using Microsoft.AspNetCore.Mvc;

namespace HolidayCoreProject.ViewComponents.Default
{
    public class _PopularDestinations:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
