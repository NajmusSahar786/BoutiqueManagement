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
            item.ItemImage = itemViewModel.ItemImage;
            int result=_itemService.AddItem(item);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data= _itemService.GetItemById(id);
            var categories = _itemService.CategoryList();
            var brands = _itemService.BrandList();
            ItemViewModel itemViewModel = new ItemViewModel();
            itemViewModel.BrandList = brands;
            itemViewModel.CategoryList = categories;
            itemViewModel.ItemId = data.ItemId;
            itemViewModel.ItemName = data.ItemName;
            itemViewModel.ItemImage = data.ItemImage;
            itemViewModel.Price = data.Price;
            itemViewModel.CategoryId=data.CategoryId;
            itemViewModel.BrandId = data.BrandId;
            return View(itemViewModel);
        }
        [HttpPost]
        public ActionResult Edit(ItemViewModel itemViewModel)
        {
            Item item = new Item();
            item.ItemName = itemViewModel.ItemName;
            item.Price = itemViewModel.Price;
            item.CategoryId = itemViewModel.CategoryId;
            item.BrandId = itemViewModel.BrandId;
            item.ItemImage = itemViewModel.ItemImage;
            item.ItemId = itemViewModel.ItemId;
            int result = _itemService.UpdateItem(item);
            return RedirectToAction("Index");
        }
    }
}