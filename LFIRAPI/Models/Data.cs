namespace LFIRAPI.Models
{
    public class Data
    {
        public static List<LocalFundingInitiativeRequestModel> LFIRList = new List<LocalFundingInitiativeRequestModel>
        {
            new LocalFundingInitiativeRequestModel
            {
                Id= 1,
                LFIRNumber = "1001",
                Title = "Florida Veterans Legal Helpline",
                Sponsor = "Burgess",
                DateOfRequest = DateTime.Parse("01/05/2023"),
                FundsRequested = 750_000M,
                Committee = "Appropriations Subcommitte on Health and Human Services",
                FilePath = "https://www.flsenate.gov/PublishedContent/Session/FiscalYear/FY2023-24/LocalFundingInitiativeRequests/FY2023-24_S1001.PDF"
            },
             new LocalFundingInitiativeRequestModel
            {
                Id= 1,
                LFIRNumber = "1005",
                Title = "Project Be Strong",
                Sponsor = "Rodriquez",
                DateOfRequest= DateTime.Parse("12/22/2022"),
                FundsRequested = 1_000_000M,
                Committee = "Appropriations Subcommitte on Health and Human Services",
                FilePath = "https://www.flsenate.gov/PublishedContent/Session/FiscalYear/FY2023-24/LocalFundingInitiativeRequests/FY2023-24_S1001.PDF"
            }
        };

    }
}
