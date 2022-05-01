using System.ComponentModel.DataAnnotations;

namespace CW2AD.Models
{
    public class Studio
    {
        [Key]
        public int StudioNumber { get; set; }
        public string StudioName { get; set; }
    }
}
