using EntityLayer.Concrete;
using HolidayCoreProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HolidayCoreProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public LoginController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        // TODO : signup set app

        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel userRegisterViewModel)
        {
            AppUser appuser = new AppUser()
            {
                Name = userRegisterViewModel.Name,
                SurName = userRegisterViewModel.SurName,
                Email = userRegisterViewModel.Mail,
                UserName = userRegisterViewModel.UserName

            };

            if (userRegisterViewModel.Password == userRegisterViewModel.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appuser, userRegisterViewModel.Password);

                if (result.Succeeded) 
                {

                    return RedirectToAction("SignIn");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("",item.Description);
                    }
                }
            }

            return View(userRegisterViewModel);
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
