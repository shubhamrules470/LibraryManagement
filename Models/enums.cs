using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public enum Language
    {
        English = 0,
        Hindi,
        Telugu,
        Tamil,
        Urdu,
        Bengali,
        Chinese,
        Russian,
        French,
        Arabic
    }

    public enum AccountStatus
    {
        Active = 0,
        Blocked
    }

    public enum Gender
    {
        Male = 0,
        Female,
        NonBinary
    }
}
