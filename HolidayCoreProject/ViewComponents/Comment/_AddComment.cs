using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace HolidayCoreProject.ViewComponents.Comment
{
    public class _AddComment:ViewComponent
    {
       // CommentManager commentManager = new CommentManager(new EfCommentDal());

      //  [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();  
        }

        //[HttpPost]
        //public IViewComponentResult InvokePost(EntityLayer.Concrete.Comment comment)
        //{
        //    comment.CommentDate =Convert.ToDateTime(DateTime.Now.ToString());
        //    comment.CommentState = true;
        //    commentManager.TAdd(comment);
        //    return View();
        //}
    }
}
