using EFDbFirstApproachCodeFirstApproachRecreateDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDbFirstApproachCodeFirstApproachRecreateDB.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            CompanyDbContext dbContext = new CompanyDbContext();
            List<Category> categories = dbContext.Categories.ToList();
            return View(categories);
        }
    }
}