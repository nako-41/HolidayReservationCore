﻿using Microsoft.AspNetCore.Mvc;

namespace HolidayCoreProject.ViewComponents.Comment
{
    public class _AddComment:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
