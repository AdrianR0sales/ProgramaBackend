namespace UserRoles.Models
{
    public class TicketStatus
    {
        public string? Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}