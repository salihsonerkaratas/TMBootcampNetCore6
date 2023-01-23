using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MemberValidator : AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(x => x.MemberName).NotEmpty().WithMessage("Üye Adı Boş Geçilemez!");
            RuleFor(x => x.MemberSurname).NotEmpty().WithMessage("Üye Adı Boş Geçilemez!");
            RuleFor(x => x.MemberMail).NotEmpty().WithMessage("Mail Adresi Boş Geçilemez!");
            RuleFor(x => x.MemberPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez!");
            RuleFor(x => x.MemberSurname).MinimumLength(8).WithMessage("Şifre En Az 8 Karakterden Oluşmalı.");
            RuleFor(x => x.MemberName).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Giriniz.");
            RuleFor(x => x.MemberSurname).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Giriniz.");
            RuleFor(x => x.MemberName).MaximumLength(25).WithMessage("En Fazla 25 Karakter Olabilir.");
            RuleFor(x => x.MemberSurname).MaximumLength(25).WithMessage("En Fazla 25 Karakter Olabilir.");
        }
    }
}
