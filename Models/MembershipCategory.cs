using System.ComponentModel.DataAnnotations;

namespace CW2AD.Models
{
    public class MembershipCategory
    {
        [Key]
        public int MembershipCategoryNumber { get; set; }

        public string MembershipCategoryDescription { get; set; }

        public string MenmbershipCategoryTotalLoans { get; set; }
    }
}
