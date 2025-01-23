using FluentValidation;

namespace TestFluentBlazorWebApp.Components.Pages.FluentValidation;

public class BusinessTripValidator : AbstractValidator<BusinessTrip>
{

    public BusinessTripValidator()
    {
        RuleFor(x => x.EmployeeName).NotEmpty().WithMessage("Ooo here you got a problem man!");
        RuleFor(x => x.MileageRegister).SetValidator(new MileageRegisterValidator());

        //Entries).ChildRules(mil =>
        //{
        //   RuleForEach(m => m.)
        //});
    }
}