namespace IssueTrackerNew.Data.Configurations
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using IssueTrackerNew.Data.Models;
    using IssueTrackerNew.Data.Validations;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> note)
        {
            note.Property(n => n.Name)
                .HasMaxLength(DataValidation.Note.NameMaxLength)
                .IsRequired();

            note.Property(n => n.Content)
                .HasMaxLength(DataValidation.Note.ContentMaxLength)
                .IsRequired();
        }
    }
}
