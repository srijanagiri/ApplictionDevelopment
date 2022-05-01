using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CW2AD.Models
{
    public class DVDTitle
    {
        [Key]
        public int DVDNumber { get; set; }
        public string DVDTiles { get; set; }
        public string DateReleased { get; set; }
        public string StandardCharge { get; set; }
        public string PenaltyCharge { get; set; }


        public int ProducerNumber { get; set; }
        public int CategoryNumber { get; set; }
        public int StudioNumber { get; set; }

        [ForeignKey("ProducerNumber")] 
        public Producer Producers { get; set; }
        [ForeignKey("CategoryNumber")]
        public DVDCategory DVDCategories { get; set; }
        [ForeignKey("StudioNumber")] 
        public Studio Studios { get; set; }

    
}
}
