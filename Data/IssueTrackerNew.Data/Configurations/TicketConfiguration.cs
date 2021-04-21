namespace IssueTrackerNew.Data.Configurations
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using IssueTrackerNew.Data.Models;
    using IssueTrackerNew.Data.Validations;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> ticket)
        {
            ticket.HasMany(t => t.Comments)
                .WithOne(p => p.Ticket)
                .HasForeignKey(t => t.TicketId);

            ticket.Property(t => t.Title)
                .HasMaxLength(DataValidation.Ticket.TicketNameMaxLength)
                .IsRequired();

            ticket.Property(t => t.Content)
                .HasMaxLength(DataValidation.Ticket.ContentMaxLength)
                .IsRequired();
        }
    }
}
