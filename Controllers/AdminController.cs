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
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}