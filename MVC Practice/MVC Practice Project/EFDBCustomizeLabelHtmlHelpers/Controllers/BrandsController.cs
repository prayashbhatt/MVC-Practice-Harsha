using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDBHtmlHelpers.Models;

namespace EFDBHtmlHelpers.Controllers
{
    public class BrandsController : Controller
    {
        // GET: Brands
        public ActionResult Index()
        {
            CompanyDbContext dbContext = new CompanyDbContext();
            List<Brand> brands = dbContext.Brands.ToList();
            return View(brands);
        }
    }
}