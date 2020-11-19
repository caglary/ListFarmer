using Entity.Concrete;
using FluentValidation;
namespace Business.ValidationRules.FluentValidation
{
    public class CiftciValidator : AbstractValidator<Ciftci>
    {
        public CiftciValidator()
        {
            RuleFor(c => c.Isim).NotEmpty().WithMessage("isim alanı boş olamaz.");
            RuleFor(c => c.Soyisim).NotEmpty().WithMessage("Soyisim alanı boş olamaz.");
            RuleFor(c => c.Mahalle).NotEmpty().WithMessage("Mahalle alanı boş olamaz.");
            RuleFor(c => c.Tc).NotEmpty().Length(11).WithMessage("Tc bilgisi 11 karakter olmalı.");
            RuleFor(c => c.KayitTarih).NotEmpty().WithMessage("Kayıt tarihi alanı boş olamaz.");
        }
    }
}
