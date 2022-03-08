using System;
using System.Linq;

namespace AmazonBooks.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }

        //public void SaveBook(Book b);
        //public void CreateBook(Book b);
        //public void DeleteBook(Book b);

    }
}
