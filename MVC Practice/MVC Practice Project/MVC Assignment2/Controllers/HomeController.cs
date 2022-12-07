using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Assignment2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        /// <summary>
        /// Index Function to accept the amount.
        /// </summary>
        /// <param name="amount">Amount Value</param>
        /// <returns>Demonition View</returns>
        public ActionResult Index(int? amount)
        {
            //Assigning the amount to the ViewBag to access it on the View.
            ViewBag.Amount = amount;
            
            return View();
        }
    }
}