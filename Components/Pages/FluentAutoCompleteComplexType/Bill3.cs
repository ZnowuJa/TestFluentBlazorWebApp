using System.Text.Json.Serialization;
namespace TestFluentBlazorWebApp.Components.Pages.FluentAutoCompleteComplexType;

public class Bill3
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
    public Location Location { get; set; } = new();
    public CostCenter CostCenter { get; set; } = new();
    public GLAccount GLAccount { get; set; } = new();
    public VATRate VATRate { get; set; } = new();

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