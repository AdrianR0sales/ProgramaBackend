using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserRoles.Models;

namespace UserRoles.Data
{
    public class AppDbContext : IdentityDbContext<Users>
    {

        public DbSet<TicketStatus> TicketStatus { get; set; }

        public DbSet<PriorityTicket> PriorityTickets { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.

            builder.Entity<TicketStatus>()
            .ToTable("TicketStatus");

            builder.Entity<Users>()
            .Property(u => u.CreatedAt)
            .HasDefaultValueSql("GETUTCDATE()");  

            builder.Entity<Users>()
            .Property(u => u.UpdatedAt)
            .HasDefaultValueSql("GETUTCDATE()");

            builder.Entity<TicketStatus>()
            .Property(u => u.CreatedAt)
            .HasDefaultValueSql("GETUTCDATE()");

            builder.Entity<TicketStatus>()
            .Property(u => u.UpdatedAt)
            .HasDefaultValueSql("GETUTCDATE()");

            builder.Entity<TicketStatus>()
            .HasIndex(ts => ts.Name)
            .IsUnique();

            builder.Entity<PriorityTicket>()
            .Property(u => u.CreatedAt)
            .HasDefaultValueSql("GETUTCDATE()");

            builder.Entity<PriorityTicket>()
            .Property(u => u.UpdatedAt)
            .HasDefaultValueSql("GETUTCDATE()");

            builder.Entity<PriorityTicket>()
            .HasIndex(ts => ts.Name)
            .IsUnique();
        }
    }
}