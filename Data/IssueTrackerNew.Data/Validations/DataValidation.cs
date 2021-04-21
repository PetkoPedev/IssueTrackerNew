namespace IssueTrackerNew.Data.Validations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal static class DataValidation
    {

        internal static class Article
        {
            internal const int NameMaxLength = 50;
            internal const int NameMinLength = 5;
            internal const int ContentMaxLength = 1000;
            internal const int ContentMinLength = 10;
        }

        internal static class Category
        {
            internal const int NameMaxLength = 50;
            internal const int NameMinLength = 5;
        }

        internal static class Comment
        {
            internal const int ContentMaxLength = 1000;
            internal const int ContentMinLength = 10;
        }

        internal static class Note
        {
            internal const int NameMaxLength = 20;
            internal const int NameMinLength = 3;
            internal const int ContentMaxLength = 500;
            internal const int ContentMinLength = 5;
        }

        internal static class Ticket
        {
            internal const int TicketNameMaxLength = 50;
            internal const int TicketNameMinLength = 5;
            internal const int ContentMaxLength = 1000;
            internal const int ContentMinLength = 10;
        }
    }
}
