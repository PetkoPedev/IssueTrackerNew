namespace IssueTrackerNew.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ArticleCategory : Category
    {
        public ArticleCategory()
        {
            this.Articles = new HashSet<Article>();
        }

        public ICollection<Article> Articles { get; set; }
    }
}
