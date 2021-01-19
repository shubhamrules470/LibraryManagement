using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class Visitor
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public DateTime DateJoined { get; set; }
        public Gender Gender { get; set; }
        public DateTime? BlockedOn { get; set; }
    }
}
