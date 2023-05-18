using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace HolidayCoreProject.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal()); 
        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();

            //var result = from item in values
            //             where item.FeatureID == 1
            //             select item.Post1Name.ToString();

            //var result = new Context();

            //var get = result.Features;

            //var getresult = from item in get
            //                where item.FeatureID == 1
            //                select item.Post1Name; 

            //ViewBag.name = getresult.ToString();
           
                            

            //ViewBag.name = result.Features.Select(x=>x.Post1Name);
            //return View(values);
            return View(values); 
        }

    }
}
