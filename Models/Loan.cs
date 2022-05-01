using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CW2AD.Models
{
    public class Loan
    {
        [Key]
        public int LoanNumber { get; set; }

        public string DateOut { get; set; }

        public string DateDue { get; set; }

        public string DateReturned { get; set; }

        public int LoanTypeNumber { get; set; }

        public int MemberNumber { get; set; }

        public int CopyNumber { get; set; }

        [ForeignKey("LoanTypeNumber")] 
        public LoanType LoanType { get; set; }

        [ForeignKey("MemberNumber")] 
        public Member Member { get; set; }

        [ForeignKey("CopyNumber")] 
        public DVDCopy DVDCopy { get; set; }
    }
}
