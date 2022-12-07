using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignment1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(String Value)
        {
            if (!String.IsNullOrEmpty(Value))
            {
                if (Value.ToLower() == "sample")
                {
                    String FileName = "~/sample.pdf";
                    return File(FileName, "application/pdf");
                }
                else if (Value.ToLower() == "gotoabout")
                {
                    return RedirectToAction("About");
                }
                else if (Value.ToLower() == "login")
                {
                    return View("Login");
                }
                else
                {
                    return Content("You have entered : " + Value);
                }
            }
            else
            {
                return Content("No value is entered.");
            }

        }

        public ActionResult About()
        {
            return Content("About Content here");
        }

    }
}