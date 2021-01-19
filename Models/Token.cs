using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class Token
    {
        public int Id { get; set; }
        public int VisitorId { get; set; }
        public string VisitorName { get; set; }
        public int BookId { get; set; }
        public string BookName { get; set; }
        public DateTime IssuedOn { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsBookReturn { get; set; }
        public DateTime? ReturnedOn { get; set; }
    }
}
