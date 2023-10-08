using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class About2Valiadator:AbstractValidator<About2>
    {
        public About2Valiadator()
        {
             RuleFor(x=>x.Description).NotEmpty().WithMessage("bos gecilemez");   
        }

    }
}
