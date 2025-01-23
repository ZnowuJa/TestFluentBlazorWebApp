using FluentValidation;

namespace TestFluentBlazorWebApp.Components.Pages.FluentValidation;

public class MileageEntryValidator : AbstractValidator<MileageRegisterEntry>
{
    public MileageEntryValidator()
    {

        RuleFor(s => s.Date).NotEmpty().WithMessage("Uzupenij datę przejazdu w kilometrówce!");
        RuleFor(s => s.Mileage).GreaterThan(0).WithMessage("Uzupełnij listę przejechanych kilometrów");
        RuleFor(s => s.Purpose).NotEmpty().WithMessage("Uzupełnij cel przejazdu!");
        RuleFor(s => s.RouteDescription).NotEmpty().WithMessage("Uzupełnij opis przejazdu!");

    }
}

public class MileageRegisterValidator : AbstractValidator<MileageRegister>
{

    public MileageRegisterValidator()
    {
        RuleForEach(x => x.Entries).SetValidator(new MileageEntryValidator());
    }



}
