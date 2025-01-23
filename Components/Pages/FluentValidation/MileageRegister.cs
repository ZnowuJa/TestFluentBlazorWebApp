namespace TestFluentBlazorWebApp.Components.Pages.FluentValidation;

public class MileageRegister
{
    public int Id { get; set; }
    public string EmployeeName { get; set; }
    public string EmployeeEmpId { get; set; }

    public string PrivateCarRegistration { get; set; }
    public string PrivateCarEngineSize { get; set; }
    public decimal MileageAllowanceRate { get; set; }
    public List<MileageRegisterEntry> Entries { get; set; } = new List<MileageRegisterEntry>();
    public decimal? TotalValue { get; set; }
    public decimal? TotalMileage { get; set; }

}


