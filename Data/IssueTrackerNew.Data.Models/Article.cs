namespace IssueTrackerNew.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using IssueTrackerNew.Data.Common.Models;

    public class Article : BaseDeletableModel<int>
    {
        public string ArticleName { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int ArticleCategoryId { get; set; }

        public virtual ArticleCategory ArticleCategory { get; set; }
    }
}
