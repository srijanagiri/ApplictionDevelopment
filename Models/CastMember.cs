using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CW2AD.Models
{
    public class CastMember
    {
        [Key]
        public int DVDNumber { get; set; }
        public int ActorNumber { get; set; }

        [ForeignKey("DVDNumber")] 
        public DVDTitle DVDTitles { get; set; }
    }
}

