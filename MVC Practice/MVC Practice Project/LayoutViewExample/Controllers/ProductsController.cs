using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutViewExample.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int? id)
        {
            var products = new[]
            {
                new {ProductId = 1, ProductName = "IPhone", Cost = 80000 },
                new {ProductId = 2, ProductName = "Printer", Cost = 30000 },
                new {ProductId = 3, ProductName = "Camera", Cost = 12000 }
            };

            if (id == null)
            {
                return Content("Please pass product id");
            }

            String ProductsName = String.Empty;

            foreach (var product in products)
            {
                if (product.ProductId == id)
                {
                    ProductsName = product.ProductName;
                }
            }

            return Content(ProductsName);
        }

        public ActionResult GetProductId(string id)
        {
            var products = new[]
            {
                new {ProductId = 1, ProductName = "IPhone", Cost = 80000 },
                new {ProductId = 2, ProductName = "Printer", Cost = 30000 },
                new {ProductId = 3, ProductName = "Camera", Cost = 12000 }
            };

            int prodId = 0;

            if (id == null)
            {
                return Content("Please place Product Id");
            }

            foreach (var product in products)
            {
                if (product.ProductName == id)
                {
                    prodId = product.ProductId;
                }
            }

            return Content(prodId.ToString());
        }
    }
}