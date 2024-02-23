using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoutiqueManagement.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int BaseCategory { get; set; }
    }
}