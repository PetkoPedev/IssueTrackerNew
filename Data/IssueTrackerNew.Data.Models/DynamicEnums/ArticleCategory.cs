namespace IssueTrackerNew.Data.Models
{
    using System.Collections.Generic;

    using IssueTrackerNew.Data.Common.Models;

    public class ArticleCategory : BaseDeletableModel<int>
    {
        public ArticleCategory()
        {
            this.Articles = new HashSet<Article>();
        }

        public string Name { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
