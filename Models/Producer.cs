using System.ComponentModel.DataAnnotations;

namespace CW2AD.Models
{
    public class Producer
    {
        [Key]
        public int ProducerNumber { get; set; }
        public string ProducerName { get; set; }

    }
}
