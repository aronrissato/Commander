using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandReadDto : CommandDtoBase
    {
        public int Id { get; set; }
        
    }
}