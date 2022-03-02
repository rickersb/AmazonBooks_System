using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazonBooks.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmazonBooks.Controllers
{
    public class PurchaseController : Controller
    {

        private iPurchaseRepository repo { get; set; }
        private Basket basket { get; set; }

        public PurchaseController(iPurchaseRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

       [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Purchases());
        }

        [HttpPost]
        public IActionResult Checkout(Purchases purchases)
        {
            if(basket.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, cart is empty");
            }

            if (ModelState.IsValid)
            {
                purchases.Lines = basket.Items.ToArray();
                repo.SavePurchase(purchases);
                basket.ClearBasket();

                return RedirectToPage("/PurchaseComplete");
            }
            else
            {
                return View();
            }
        }
    }
}
