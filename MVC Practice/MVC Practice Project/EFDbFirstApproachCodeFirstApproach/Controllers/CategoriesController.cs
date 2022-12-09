using EFDbFirstApproachCodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDbFirstApproach.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            CompanyDbContext eFDBFirstDatabaseEntities = new CompanyDbContext();
            List<Category> categories = eFDBFirstDatabaseEntities.Categories.ToList();
            return View(categories);
        }
    }
}