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

    public class TicketStatusConfiguration : IEntityTypeConfiguration<TicketStatus>
    {
        public void Configure(EntityTypeBuilder<TicketStatus> ticketStatus)
        {
            ticketStatus.Property(ts => ts.Name)
                .HasMaxLength(DataValidation.TicketStatus.TicketStatusNameMaxLength)
                .IsRequired();

            ticketStatus.HasMany(ts => ts.Tickets)
                .WithOne(t => t.TicketStatus)
                .HasForeignKey(ts => ts.TicketStatusId);
        }
    }
}
