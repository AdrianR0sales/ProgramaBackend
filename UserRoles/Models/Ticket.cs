using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserRoles.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public string TicketNumber { get; set; } = string.Empty;

        [MaxLength(255)]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        // Relación opcional a TicketStatus (su Id es string/Guid)
        public string? StatusId { get; set; }
        public TicketStatus? Status { get; set; }

        // Relación opcional a PriorityTicket
        public int? PriorityId { get; set; }
        public PriorityTicket? Priority { get; set; }

        public DateTime CreatedAT { get; set; } = DateTime.Now;
        public DateTime? UpdateAT { get; set; }
        public DateTime? ResolvedAT { get; set; }
        public DateTime? CloseAT { get; set; }
        public DateTime? DueDate { get; set; }

        // Autor y relaciones a usuarios (todas opcionales)
        public string? CreatedById { get; set; }
        public string? AssignedToId { get; set; }
        public string? ResolvedById { get; set; }
        public string? ClosedById { get; set; }

        [ForeignKey(nameof(CreatedById))]
        public Users? CreatedBy { get; set; }

        [ForeignKey(nameof(AssignedToId))]
        public Users? AssignedTo { get; set; }

        [ForeignKey(nameof(ResolvedById))]
        public Users? ResolvedBy { get; set; }

        [ForeignKey(nameof(ClosedById))]
        public Users? ClosedBy { get; set; }
    }
}