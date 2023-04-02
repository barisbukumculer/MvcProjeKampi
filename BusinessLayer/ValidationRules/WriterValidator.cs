using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        Context context = new Context();
        public WriterValidator()
        {
            
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Boş olamaz.");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazarın Soyadı Boş olamaz.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında Kısmını Boş bırakamazsınız.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Ünvan Kısmını Boş bırakamazsınız.");
            RuleFor(x=>x.WriterAbout).Matches("a"). WithMessage("Hakkında Kısmınında en az 1 adet a harfi içermelidir.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girin.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girin.");
        }
    }
}
