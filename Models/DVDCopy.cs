using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace CW2AD.Models
{
    public class DVDCopy
    {
        [Key]
        public int CopyNumber { get; set; }
        public int DVDNumber { get; set; }
        public string DatePurchased { get; set; }


       [ForeignKey("DVDNumber")] 
        public Producer Producers { get; set; }
    
}
}
