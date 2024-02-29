using BoutiqueManagement.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoutiqueManagement.Controllers
{
    public class BaseController : Controller
    {
        private readonly IItemService _itemService;
        public BaseController(IItemService itemService)
        {
            _itemService = itemService;
        }
    }
}