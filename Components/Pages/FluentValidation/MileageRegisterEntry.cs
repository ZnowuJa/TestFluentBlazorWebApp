namespace TestFluentBlazorWebApp.Components.Pages.FluentValidation;

public class MileageRegisterEntry
{
    public int Id { get; set; }
    public DateOnly? Date { get; set; }
    public decimal? TotalValue { get; set; }

    public int? Mileage { get; set; }
    public string? RouteDescription { get; set; }
    public string? Purpose { get; set; }
}
