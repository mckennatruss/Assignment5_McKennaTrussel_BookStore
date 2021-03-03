using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5_McKennaTrussel_BookStore.Models.ViewModels
{
    public class BookListViewModel
    {
        //home controller loads in these Books
        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
