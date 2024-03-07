using BoutiqueManagement.IServices;
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
    }
}