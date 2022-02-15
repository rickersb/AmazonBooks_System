using System;
using System.Linq;

namespace AmazonBooks.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
       
    }
}
