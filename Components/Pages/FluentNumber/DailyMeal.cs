namespace TestFluentBlazorWebApp.Components.Pages.FluentNumber;

public class DailyMeal
{
    public int StageId { get; set; }
    public Guid formGuid { get; set; } = Guid.NewGuid();
    public string CountryCode { get; set; } = string.Empty;
    public string CountryName { get; set; } = string.Empty;
    public decimal AllowanceRate { get; set; } = 0;
    public string AllowanceRateCurrency { get; set; }
    public int Duration { get; set; } = 0;
    public decimal? BreakfastReduction { get; set; } = 0;
    public decimal? LunchReduction { get; set; } = 0;
    public decimal? DinnerReduction { get; set; } = 0;
    public int CoveredBreakfasts { get; set; } = 0;
    public int CoveredLunches { get; set; } = 0;
    public int CoveredDinners { get; set; } = 0;
    public int Nights { get; set; } = 0;
    //public decimal Total { get; set; } = 0;
    public decimal Total
    {
        get
        {
            decimal total = 0;

            if (CountryCode != "PL")
            {
                total -= (CoveredBreakfasts * AllowanceRate * 0.15m);
                total -= (CoveredLunches * AllowanceRate * 0.3m);
                total -= (CoveredDinners * AllowanceRate * 0.3m);
            }
            else
            {
                total -= (CoveredBreakfasts * AllowanceRate / 4);
                total -= (CoveredLunches * AllowanceRate / 2);
                total -= (CoveredDinners * AllowanceRate / 4);
            }

            return Math.Round(total, 2);
        }
    }
    public bool Included { get; set; } = true;
}

