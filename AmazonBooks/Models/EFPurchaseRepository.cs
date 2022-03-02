using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AmazonBooks.Models
{
    public class EFPurchaseRepository : iPurchaseRepository
    {

        private BookstoreContext context;

        public EFPurchaseRepository (BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Purchases> Purchases => context.Purchase.Include(x=>x.Lines).ThenInclude(x=>x.Book);

        public void SavePurchase(Purchases purchases)
        {
            context.AttachRange(purchases.Lines.Select(x => x.Book));

            if(purchases.PurchaseId == 0)
            {
                context.Purchase.Add(purchases);
            }

            context.SaveChanges();
        }


    }
}
