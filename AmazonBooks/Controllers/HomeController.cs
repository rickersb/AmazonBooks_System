using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AmazonBooks.Models;
using AmazonBooks.Models.ViewModels;

//Bootstrap1: styled the login form on the loginform view to be more unique. Added some rounded borders too.
//Bootstrap2: on the admin layout page I made it so that the log out button stays at the top left of the page no matter how far you scroll down



namespace AmazonBooks.Controllers
{
    public class HomeController : Controller
    {


        private IBookstoreRepository repo;

        public HomeController (IBookstoreRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(string category, int pageNum = 1)
        {
            int pageSize = 10;

            var x = new BooksViewModel
            {
                Books = repo.Books
                .Where(p => p.Category == category || category == null)
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks =
                    (category == null
                        ? repo.Books.Count()
                        : repo.Books.Where(x => x.Category == category).Count()),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };
            

            return View(x);
        }

        

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
