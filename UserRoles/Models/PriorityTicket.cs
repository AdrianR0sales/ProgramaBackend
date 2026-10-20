using System.ComponentModel.DataAnnotations;

namespace UserRoles.Models
{
    public class PriorityTicket
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}