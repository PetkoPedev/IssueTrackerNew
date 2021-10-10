namespace IssueTrackerNew.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TicketCategory : Category
    {
        public TicketCategory()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
