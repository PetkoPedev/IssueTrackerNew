namespace IssueTrackerNew.Data.Configurations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using IssueTrackerNew.Data.Models;
    using IssueTrackerNew.Data.Validations;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TicketPriorityConfiguration : IEntityTypeConfiguration<TicketPriority>
    {
        public void Configure(EntityTypeBuilder<TicketPriority> ticketPriority)
        {
            ticketPriority.Property(tp => tp.Name)
                .HasMaxLength(DataValidation.TicketPriority.TicketPriorityNameMaxLength)
                .IsRequired();

            ticketPriority.HasMany(tp => tp.Tickets)
                .WithOne(t => t.TicketPriority)
                .HasForeignKey(tp => tp.TicketPriorityId);
        }
    }
}
