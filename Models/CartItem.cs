using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoutiqueManagement.Models
{
    public class CartItem
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
    }
}