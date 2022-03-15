using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazonBooks.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmazonBooks.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> x, SignInManager<IdentityUser> y)
        {
            userManager = x;
            signInManager = y;
        }

        [HttpGet]
        public IActionResult Login(string returnURL)
        {
            return View(new LoginModel { ReturnURL = returnURL });
        }
        [HttpPost]
        public async Task<IActionResult> Login (LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByNameAsync(loginModel.UserName);
                if(user != null)
                {
                    if((await signInManager.PasswordSignInAsync(user, loginModel.Password, false, false)).Succeeded)
                    {
                        return Redirect(loginModel?.ReturnURL ?? "/Admin");
                    }
                }

                
            }
            ModelState.AddModelError("", "Invalid name or password");
            return View(loginModel);
        }
        
        public async Task<RedirectResult> Logout(string returnURL = "/")
        {
            await signInManager.SignOutAsync();
            return Redirect(returnURL);
        }

    }
}
