namespace IssueTrackerNew.Data.Models.DynamicEnums
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using IssueTrackerNew.Data.Common.Models;

    public class TicketCategory : BaseDeletableModel<int>
    {
        public TicketCategory()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        public string Name { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
