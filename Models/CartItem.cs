using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoutiqueManagement.Models
{
    public class CartItem
    {
        [Key]
        public int CartId { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
    }
}