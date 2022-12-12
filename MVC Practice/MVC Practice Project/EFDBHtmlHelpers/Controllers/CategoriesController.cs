using EFDBHtmlHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDBHtmlHelpers.Controllers
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