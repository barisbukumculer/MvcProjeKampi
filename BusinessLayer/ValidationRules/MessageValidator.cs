﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator:AbstractValidator<Message>
    {
      public MessageValidator() 
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı Adresi Boş olamaz.");
            //RuleFor(x => x.SenderMail).NotEmpty().WithMessage("Gönderen Adresi Boş olamaz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu Boş Geçemezsiniz.");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı Boş Geçemezsiniz.");
            RuleFor(x => x.ReceiverMail).EmailAddress().WithMessage("Email Adresi Geçerli Değil.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girin.");
            RuleFor(x => x.Subject).MaximumLength(20).WithMessage("Lütfen en fazla 100 karakter girin.");
        } 
    }
}
