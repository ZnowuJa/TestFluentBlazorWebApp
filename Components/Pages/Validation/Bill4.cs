using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace TestFluentBlazorWebApp.Components.Pages.Validation;

public class Bill4
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public string Reason { get; set; }
    public List<InvoiceMapping> Posting { get; set; }
    
}
public enum BillReasons
{
    Posiłek,
    Bilet,
    Nocleg,
    Inne
}
public class InvoiceMapping
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Proszę wybrać lokalizację!")]
    public Location Location { get; set; }

    [Required(ErrorMessage = "Proszę wybrać MPK!")]
    public CostCenter CostCenter { get; set; }

    [Required(ErrorMessage = "Proszę wybrać konto!")]
    public GLAccount GLAccount { get; set; }

    [Required(ErrorMessage = "Proszę wybrać stawkę VAT!")]
    public VATRate VATRate { get; set; }
}
public class CostCenter
{
    public int Id { get; set; }
    public string MPK { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }

}
public class GLAccount
{
    public int Id { get; set; }
    public string AccountNumber { get; set; }
    public string Description { get; set; }

}
public class VATRate
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Percentage { get; set; }
    public string Information { get; set; }

}
public class Location()
{
    public string Name { get; set; } = string.Empty;
    public string SapNumber { get; set; } = string.Empty;
}

public class LocationNotEmptyValidationAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var trip = (Location)validationContext.ObjectInstance;
        if (trip == null)
        {
            return new ValidationResult("Proszę wybrać kraj docelowy!");
        }
        return ValidationResult.Success;
    }
}