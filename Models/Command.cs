using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string HowTo { get; set; }

        [MaxLength(100)]
        public string Line { get; set; }
        
        [MaxLength(100)]
        public string Platform { get; set; }
    }
}