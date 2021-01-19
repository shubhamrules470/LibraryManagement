using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Subject { get; set; }
        public Language Language { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public DateTime PublicationDate { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public int NoOfPages { get; set; }
        public double Price { get; set; }
    }
}
