using BoutiqueManagement.IServices;
using BoutiqueManagement.Models;
using BoutiqueManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoutiqueManagement.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class ItemsController : Controller
    {
        private IItemService _itemService;


        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }
        // GET: Items
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetData()
        {
            var result = _itemService.GetItems();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult AddItem()
        {
            var categories = _itemService.CategoryList();
            var brands = _itemService.BrandList();
            ItemViewModel itemViewModel = new ItemViewModel();
            itemViewModel.BrandList = brands;
            itemViewModel.CategoryList = categories;
            return View(itemViewModel   );
        }
        [HttpPost]
        public ActionResult AddItem(ItemViewModel itemViewModel)
        {
            Item item = new Item();
            item.ItemName = itemViewModel.ItemName;
            item.Price = itemViewModel.Price;
            item.CategoryId = itemViewModel.CategoryId;
            item.BrandId = itemViewModel.BrandId;
            int result=_itemService.AddItem(item);
            return RedirectToAction("Index");
        }
    }
}