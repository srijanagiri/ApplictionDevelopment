using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CW2AD.Models
{
    public class Member
    {
        [Key]
        public int MemberNumber { get; set; }

        public string MemberLastName { get; set; }

        public string MemberFirstName { get; set; }

        public string MemberAddress { get; set; }

        public string MemberDateOfBirth { get; set; }

        public int MembershipCategoryNumber { get; set; }


        [ForeignKey("MembershipCategoryNumber")] 
        public MembershipCategory MembershipCategories { get; set; }

    }
}
