using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresi Boş olamaz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adı Boş olamaz.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Boş olamaz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girin.");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girin.");
            RuleFor(x => x.Subject).MaximumLength(20).WithMessage("Lütfen en fazla 50 karakter girin.");
        }
    }
}
