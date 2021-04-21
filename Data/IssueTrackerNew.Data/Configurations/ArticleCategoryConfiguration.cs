namespace IssueTrackerNew.Data.Configurations
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using IssueTrackerNew.Data.Models;
    using IssueTrackerNew.Data.Validations;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ArticleCategoryConfiguration : IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> category)
        {
            category.Property(c => c.Name)
                .HasMaxLength(DataValidation.Category.NameMaxLength)
                .IsRequired();

            category.HasMany(c => c.Articles)
                .WithOne(a => a.ArticleCategory)
                .HasForeignKey(c => c.ArticleCategoryId);
        }
    }
}
