using BoutiqueManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoutiqueManagement.ViewModel
{
    public class ItemViewModel
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public List<Category> CategoryList { get; set; }
        [Display(Name = "Brand")]
        public int BrandId { get; set; }
        public List<Brand> BrandList { get; set; }
        public byte[] ItemImage { get; set; }
    }
}