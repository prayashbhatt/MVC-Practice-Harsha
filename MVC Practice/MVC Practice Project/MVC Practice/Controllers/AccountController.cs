using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Practice.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login(String UserName,String Password)
        {
            if (UserName == "admin" && Password == "manager")
            {
                return RedirectToAction("Dashboard", "Admin");
            }
            else
            {
                return RedirectToAction("InvalidLogin");
            }
            //return View();
        }

        public ActionResult InvalidLogin()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}