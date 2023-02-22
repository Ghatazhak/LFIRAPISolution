using Microsoft.AspNetCore.Cors;
using System.ComponentModel.DataAnnotations;

namespace LFIRAPI.Models
{
    public class LocalFundingInitiativeRequestModel
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Form Number")]
        [Required]
        public string LFIRNumber { get; set; }

        [Display(Name = "Project Title")]
        [Required]
        public string Title { get; set; }


        [Display(Name = "Originating Sponsor")]
        [Required] 
        public string Sponsor { get; set; }

        [Display(Name = "Date of Request")]
        [Required]
        public DateTime DateOfRequest { get; set; }

        [Display(Name = "Requested Funds")]
        [Required]
        public Decimal FundsRequested { get; set; }

        [Display(Name = "Committee/Subcomittee")]
        [Required]
        public string Committee { get; set; }

        [Required]
        public string FilePath { get; set; }

    }
}
