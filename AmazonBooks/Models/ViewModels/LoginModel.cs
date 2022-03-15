using System;
using System.ComponentModel.DataAnnotations;

namespace AmazonBooks.Models.ViewModels
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string ReturnURL { get; set; }



        
    }
}
