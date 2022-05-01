using System.ComponentModel.DataAnnotations;

namespace CW2AD.Models
{
    public class User

    {
        [Key]
        public int UserNumber { get; set; }
        public string UserName { get; set; }
        public bool UserType { get; set; }

        public string UserPassword { get; set; }
    }
}
