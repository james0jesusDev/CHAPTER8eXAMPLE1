using System.ComponentModel.DataAnnotations;

namespace cHAPTER8eXAMPLE1.Models
{
    public class Applicant
    {

        public int ApplicantId { get; set; }
        [Required, Display(Name ="Your Name")]


        public string? ApplicantName { get; set; }
        [Required]


        public int ACTScore { get; set; }
        public string? DecisionNote { get; set; }

    }
}
