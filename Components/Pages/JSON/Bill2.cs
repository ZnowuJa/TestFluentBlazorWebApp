namespace TestFluentBlazorWebApp.Components.Pages.JSON;

public class Bill2()
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public string Reason { get; set; }

    public string? FilePath { get; set; }
    public string? AttUrl { get; set; }
    public string? OriginalFileName { get; set; }
    public Location Location { get; set; }
}

public class Location()
{
    public string Name { get; set; } = string.Empty;
    public string SapNumber { get; set; } = string.Empty;
}
