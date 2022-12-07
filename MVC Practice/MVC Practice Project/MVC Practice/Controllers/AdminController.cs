using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Practice.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult DashBoard()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Tollfree = "456-456-456";
            return View();
        }
    }
}