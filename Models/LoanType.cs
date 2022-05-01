using System.ComponentModel.DataAnnotations;

namespace CW2AD.Models
{
    public class LoanType
    {
        [Key]
        public int LoanTypeNumber { get; set; }

        public string Loantype { get; set; }

        public string LoanDuration { get; set; }

    }
}
