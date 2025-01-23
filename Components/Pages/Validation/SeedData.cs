namespace TestFluentBlazorWebApp.Components.Pages.Validation;

public static class SeedData
{
    public static IQueryable<Location> GetLocations()
    {
        return new List<Location>
            {
                new Location { Name = "Location1", SapNumber = "SAP123" },
                new Location { Name = "Location2", SapNumber = "SAP456" },
                new Location { Name = "Location3", SapNumber = "1578" },
                new Location { Name = "Location3", SapNumber = "157891" },
                new Location { Name = "Location3", SapNumber = "157892" },
                new Location { Name = "Location3", SapNumber = "157888" }
            }.AsQueryable();
    }

    public static IQueryable<CostCenter> GetCostCenters()
    {
        return new List<CostCenter>
            {
                new CostCenter { Id = 1, MPK = "MPK001", Description = "Cost Center 1", Text = "Text1" },
                new CostCenter { Id = 2, MPK = "MPK002", Description = "Cost Center 2", Text = "Text2" },
                new CostCenter { Id = 3, MPK = "MPK003", Description = "Cost Center 3", Text = "Text3" }
            }.AsQueryable();
    }

    public static IQueryable<GLAccount> GetGLAccounts()
    {
        return new List<GLAccount>
            {
                new GLAccount { Id = 1, AccountNumber = "ACC001", Description = "GL Account 1" },
                new GLAccount { Id = 2, AccountNumber = "ACC002", Description = "GL Account 2" },
                new GLAccount { Id = 3, AccountNumber = "ACC003", Description = "GL Account 3" }
            }.AsQueryable();
    }

    public static IQueryable<VATRate> GetVATRates()
    {
        return new List<VATRate>
            {
                new VATRate { Id = 1, Name = "VAT1", Percentage = 5.0, Information = "Info1" },
                new VATRate { Id = 2, Name = "VAT2", Percentage = 10.0, Information = "Info2" },
                new VATRate { Id = 3, Name = "VAT3", Percentage = 15.0, Information = "Info3" }
            }.AsQueryable();
    }
    public static IQueryable<InvoiceMapping> GetPostings()
    {
        return new List<InvoiceMapping>
            {
                new InvoiceMapping
                {
                    Id = 1,
                    Location =  new Location { Name = "Location1", SapNumber = "1556" },
                    CostCenter = new CostCenter { Id = 2, MPK = "092000", Description = "Cost Center 2", Text = "Text2" },
                    GLAccount = new GLAccount { Id = 1, AccountNumber = "739000", Description = "GL Account 1" },
                    VATRate = new VATRate { Id = 1, Name = "VAT23", Percentage = 23, Information = "Info1" }
                },
                new InvoiceMapping
                {
                    Id = 2,
                    Location = new Location { Name = "Location4", SapNumber = "SAP321" },
                    CostCenter = new CostCenter { Id = 3, MPK = "MPK003", Description = "Cost Center 3", Text = "Text3" },
                    GLAccount = new GLAccount { Id = 3, AccountNumber = "ACC003", Description = "GL Account 3" },
                    VATRate =  new VATRate { Id = 1, Name = "VAT23", Percentage = 23, Information = "Info1" }
                }
                
            }.AsQueryable();
    }
}
