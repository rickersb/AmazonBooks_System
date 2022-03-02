using System;
using System.Linq;

namespace AmazonBooks.Models
{
    public interface iPurchaseRepository
    {
        IQueryable<Purchases> Purchases { get; }

        void SavePurchase(Purchases purchases)
        {

        }
    }
}
