using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDbFirstApproach.Models;

namespace EFDbFirstApproach.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            EFDBFirstDatabaseEntities eFDBFirstDatabaseEntities = new EFDBFirstDatabaseEntities();
            List<Category> categories = eFDBFirstDatabaseEntities.Categories.ToList();
            return View(categories);
        }
    }
}