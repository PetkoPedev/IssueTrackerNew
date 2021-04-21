namespace IssueTrackerNew.Data.Configurations
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using IssueTrackerNew.Data.Models;
    using IssueTrackerNew.Data.Models.DynamicEnums;
    using IssueTrackerNew.Data.Validations;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TicketCategoryConfiguration : IEntityTypeConfiguration<TicketCategory>
    {
        public void Configure(EntityTypeBuilder<TicketCategory> ticketCategory)
        {
            ticketCategory.Property(c => c.Name)
                .HasMaxLength(DataValidation.Category.NameMaxLength)
                .IsRequired();

            ticketCategory.HasMany(c => c.Tickets)
                .WithOne(a => a.TicketCategory)
                .HasForeignKey(c => c.TicketCategoryId);
        }
    }
}
