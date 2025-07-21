using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandCreateDto :CommandDtoBase
    {
        [MaxLength(100)] 
        public string Platform { get; set; }
    }
}