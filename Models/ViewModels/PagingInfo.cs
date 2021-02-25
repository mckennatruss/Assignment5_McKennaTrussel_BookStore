using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5_McKennaTrussel_BookStore.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        //casting with (decimal) or (int)
        //math.ceiling rounds to higher number
        public int TotalPages => (int) Math.Ceiling((decimal) TotalNumItems / ItemsPerPage);
    }
}





