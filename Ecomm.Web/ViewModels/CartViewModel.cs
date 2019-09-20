using Ecomm.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomm.Web.ViewModels
{
    public class CartViewModel
    {
        public ShoppingCart Cart { get; set; }

        [Required]
        [Display]
        public string CustomerName { get; set; }

        [Required]
        [EmailAddress]
        [Display]
        public string Email { get; set; }

        [Required]
        [CreditCard]
        [Display]
        public string CreditCard { get; set; }
    }
}
