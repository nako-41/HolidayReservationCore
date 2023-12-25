using System.ComponentModel.DataAnnotations;

namespace HolidayCoreProject.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage="please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "please enter your Surname")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "please enter your UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "please enter your e-mail address")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "please enter your Password ")]
        public string Password { get; set; }

        [Required(ErrorMessage = "please enter your Password again ")]
        [Compare("Password",ErrorMessage = "passwords are not compatible")]
        public string ConfirmPassword { get; set; }

    }
}
