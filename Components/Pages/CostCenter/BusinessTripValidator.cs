using FluentValidation;

namespace TestFluentBlazorWebApp.Components.Pages.FluentValidation;

public class BusinessTripValidator : AbstractValidator<BusinessTrip>
{

    public BusinessTripValidator()
    {
        //RuleFor(x => x.EmployeeName)
        //    .NotEmpty().WithMessage("Ooo here you got a problem man!")
        //    .MinimumLength(3).WithMessage("Employee name must be at least 3 characters long.");
        //RuleFor(x => x.MileageRegister).SetValidator(new MileageRegisterValidator());

        //Entries).ChildRules(mil =>
        //{
        //   RuleForEach(m => m.)
        //});
    }
}