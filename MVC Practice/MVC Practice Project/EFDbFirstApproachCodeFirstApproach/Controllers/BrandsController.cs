using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDbFirstApproachCodeFirstApproach.Models;

namespace EFDbFirstApproach.Controllers
{
    public class BrandsController : Controller
    {
        // GET: Brands
        public ActionResult Index()
        {
            CompanyDbContext eFDBFirstDatabaseEntities = new CompanyDbContext();
            List<Brand> brands = eFDBFirstDatabaseEntities.Brands.ToList();
            return View(brands);
        }
    }
}