using FluentValidation;
using Sipay_Bootcamp_HilalDemir.Entities.Concrete;

namespace Sipay_Bootcamp_HilalDemir.ValidationRules
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.Name).NotEmpty().Length(5, 100).WithMessage("Kişi ismi zorunludur ve 5 ile 100 karakter arasında olmalıdır.");
            RuleFor(p => p.Lastname).NotEmpty().Length(5, 100).WithMessage("Soyisim gereklidir. Soyisim 5 ile 100 karakter arasında olmalıdır.");
            RuleFor(p => p.Phone).NotEmpty().Matches(@"^\d{11}$").WithMessage("Personel telefon numarası");
            RuleFor(p => p.AccessLevel).InclusiveBetween(1, 5).WithMessage("Erişim 1 ile 5 personel arasında olmalı");
            RuleFor(p => p.Salary).NotEmpty().InclusiveBetween(5000, 50000).WithMessage("Personel maaaşı 500 ile 5000 arasında olmalıdır.");
        }
    }
}
