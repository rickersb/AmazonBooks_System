using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AmazonBooks.Models
{
    public class Purchases
    {
        
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a name:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter email:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter address:")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }


        [Required(ErrorMessage = "Please enter city:")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter state:")]
        public string State { get; set; }

        
        public string ZipCode { get; set; }


    }
}
