using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazonBooks.Infrastructure;
using AmazonBooks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AmazonBooks.Pages
{
    public class CartModel : PageModel
    {
        //private int projectId;

        private IBookstoreRepository repo { get; set; }

        public Basket basket { get; set; }
        public string ReturnURL { get; set; }

        public CartModel (IBookstoreRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        

        public void OnGet(string returnURL)
        {
            ReturnURL = returnURL ?? "/";
            //basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
        }

        public IActionResult OnPost(int bookId, string returnURL)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            //basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
            basket.AddItem(b, 1);

            //HttpContext.Session.SetJson("basket", basket);

            return RedirectToPage(new { ReturnURL = returnURL });

        }
        public IActionResult OnPostRemove(int bookId, string returnURL)
        {
            basket.RemoveItem(basket.Items.First(x => x.Book.BookId == bookId).Book);

            return RedirectToPage( new {ReturnURL = returnURL});
        }
        
    }
}
