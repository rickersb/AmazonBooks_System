using System;
using AmazonBooks.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmazonBooks.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket basket;
        public CartSummaryViewComponent(Basket cartService)
        {
            basket = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}
