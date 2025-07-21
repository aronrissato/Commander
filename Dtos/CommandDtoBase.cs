using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandDtoBase
    {
        [Required]
        [MaxLength(100)] 
        public string HowTo { get; set; }
        
        [MaxLength(100)] 
        public string Line { get; set; }
    }
}