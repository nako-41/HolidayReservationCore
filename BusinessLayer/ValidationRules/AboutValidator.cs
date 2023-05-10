using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("aciklama kismini lutfen doldurunuz...!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("lutfen gorsel seciniz");
            //RuleFor(x => x.Description).MinimumLength(50).WithMessage("");
            RuleFor(x => x.Description).MaximumLength(100).WithMessage("lutfen aciklamayi kisaltin"); ;
            
        }

    }
}
