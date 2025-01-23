using FluentValidation;

namespace TestFluentBlazorWebApp.Components.Pages.FluentValidation;

public class BusinessTrip
{
    public int Id { get; set; }
    public string EmployeeName { get; set; }
    public MileageRegister MileageRegister { get; set; }

}
