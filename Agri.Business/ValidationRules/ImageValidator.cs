using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Agri.Entity.Entities;
using FluentValidation.AspNetCore;
using System.Security.Cryptography.X509Certificates;

namespace Agri.Business.ValidationRules
{
    public class ImageValidator:AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Bu alanda 20 karakterden fazla karakter kullanamazsınız");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Bu alanda 50 karakterden fazla karakter kullanamazsınız");
            RuleFor(x => x.Title).MinimumLength(8).WithMessage("Bu alan 8 karakterden az olamaz");
            RuleFor(x => x.Description).MinimumLength(15).WithMessage("Bu alan 15 karakterden az olamaz");

        }
    }
}
