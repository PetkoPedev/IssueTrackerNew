namespace IssueTrackerNew.Data.Configurations
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using IssueTrackerNew.Data.Models;
    using IssueTrackerNew.Data.Validations;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> article)
        {
            article.Property(a => a.ArticleName)
                .HasMaxLength(DataValidation.Article.NameMaxLength)
                .IsRequired();

            article.Property(a => a.Content)
                .HasMaxLength(DataValidation.Article.ContentMaxLength)
                .IsRequired();
        }
    }
}
