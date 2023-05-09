using Agri.Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Agri.Business.ValidationRules
{
    public class StuffValidator:AbstractValidator<Stuff>
    {
        public StuffValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Takım çalışanı ismi boş olamaz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev kısmını boş bırakamazsınız");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Resim eklemelisiniz");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("50 karakterden uzun isim olamaz");
            RuleFor(x => x.Name).MinimumLength(4).WithMessage("İsim ve soyisim alanı 4 karakterden uzun olmalıdır");
            RuleFor(x=>x.Title).MaximumLength(50).WithMessage("50 karakterden uzun title olamaz");
        }

    }
}
