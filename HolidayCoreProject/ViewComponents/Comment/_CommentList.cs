using Microsoft.AspNetCore.Mvc;

namespace HolidayCoreProject.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
