namespace IssueTrackerNew.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using IssueTrackerNew.Data.Common.Models;

    public class Status : BaseDeletableModel<int>
    {
        public Status()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        public string Name { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
