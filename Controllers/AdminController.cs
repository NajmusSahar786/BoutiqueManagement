﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BoutiqueManagement.IServices;
using BoutiqueManagement.Models;
using BoutiqueManagement.Services;
using BoutiqueManagement.ViewModel;
using Newtonsoft.Json;

namespace BoutiqueManagement.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        // GET: Admin
        private IItemService _itemService;

     
        public AdminController(IItemService itemService)
        {
            _itemService = itemService;
        }


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