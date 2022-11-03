using System.ComponentModel.DataAnnotations;


namespace SendEmailApi.Models
{
    public class EmailDto
    {
        [Required]
        public string? To { get; set; }
        [Required]
        public string? Subject { get; set; }
        [Required]
        [DataType(DataType.Html)]
        public string? Body { get; set; }
        
    }
}