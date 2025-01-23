using FluentValidation;

namespace TestFluentBlazorWebApp.Components.Pages.FluentValidation;

public class BusinessTrip
{
    public int Id { get; set; }
    public string EmployeeName { get; set; }
    public MileageRegister MileageRegister { get; set; }

}
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