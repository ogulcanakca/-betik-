using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using αbetik.ELibrary.Entities.Concrete;

namespace αbetik.ELibrary.Business.ValidationRules.FluentValidation
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            
            RuleFor(p => p.FirstName).NotEmpty().WithMessage("Ad boş bırakılamaz.");
            RuleFor(p => p.LastName).NotEmpty().WithMessage("Soyad boş bırakılamaz.");
            RuleFor(p => p.TcNo).NotEmpty().WithMessage("TC kimlik numarası boş bırakılamaz.");
            RuleFor(p => p.Age).NotEmpty().WithMessage("Yaş boş bırakılamaz.");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Şifre boş bırakılamaz.");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email boş bırakılamaz.");
            RuleFor(p => p.TakenBookId).NotEmpty().WithMessage("Validasyon hatası : TakenBookId doğru biçimde değil ya da boş.");
            RuleFor(p => p.DeadTime).NotEmpty().WithMessage("Bitiş zamanı boş bırakılamaz.");
            RuleFor(p => p.StarterTime).NotEmpty().WithMessage("Başlangıç zamanı boş bırakılamaz.");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Email doğru biçimde değil.");
        }
        
    }
}
