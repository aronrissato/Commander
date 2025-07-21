using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandUpdateDto : CommandDtoBase
    {
        [MaxLength(100)] 
        public string Platform { get; set; }
    } 
}