using Entity.Concrete;
using FluentValidation;
namespace Business.ValidationRules.FluentValidation
{
    public class DilekceValidator : AbstractValidator<Dilekce>
    {
        public DilekceValidator()
        {
            RuleFor(I => I.CiftciId).NotEmpty().WithMessage("Lütfen Çiftçi Id alanını doldurunuz.");
            RuleFor(I => I.DilekceNumarasi).NotEmpty().WithMessage("Lütfen dilekce Numarası alanını doldurunuz.");
            RuleFor(I => I.UretimYili).NotEmpty().WithMessage("Lütfen Üretim yılı alanını doldurunuz.");
            RuleFor(I => I.UretimYili).Length(4).WithMessage("Lütfen üretim yılı bilgisini doğru giriniz.");
        }
    }
}
