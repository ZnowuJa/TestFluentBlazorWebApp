namespace TestFluentBlazorWebApp.Components.Pages.ObjectWithFile;

public class Bill()
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public string Reason { get; set; }
    public string? FilePath { get; set; }
    public string? AttUrl { get; set; }
    public string? OriginalFileName { get; set; }

}


public enum BillReasons
{
    Posiłek,
    Bilet,
    Nocleg,
    Inne
}