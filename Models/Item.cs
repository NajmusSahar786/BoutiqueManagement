using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoutiqueManagement.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public byte[] ItemImage { get; set; }
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
    }
}