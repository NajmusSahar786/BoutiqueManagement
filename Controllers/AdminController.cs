using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BoutiqueManagement.IServices;
using BoutiqueManagement.Models;
using BoutiqueManagement.ViewModel;

namespace BoutiqueManagement.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private IItemService _service;
        public AdminController(IItemService service)
        {
            this._service = service;
        }

        // GET: Admin
        public ActionResult Index()
        {
            this._service.Serve();
            return View();
        }

        public ActionResult CreateItem()
        {
            ItemViewModel itemViewModel = new ItemViewModel();

            return View();
        }
    }
}