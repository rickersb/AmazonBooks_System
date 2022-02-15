using System;
using System.Linq;

namespace AmazonBooks.Models.ViewModels
{
    public class BooksViewModel
    {
        public IQueryable<Book> Books { get; set; }
        public PageInfo PagInfo { get; set; }
        public PageInfo PageInfo { get; internal set; }
    }
}
