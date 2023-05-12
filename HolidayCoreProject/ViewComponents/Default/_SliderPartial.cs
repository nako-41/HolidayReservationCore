using Microsoft.AspNetCore.Mvc;

namespace HolidayCoreProject.ViewComponents.Default
{
    public class _SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
