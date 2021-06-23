using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class TicketsModel
    {
        public int? TicketsId { get; set; }
        [Required]
        public int? ProjectId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}