using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelExample.Models;

namespace ModelExample.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product { ProductId  = 101, ProductName = "AC", Rate = 45000},
                new Product { ProductId  = 102, ProductName = "Mobile", Rate = 38000},
                new Product { ProductId  = 103, ProductName = "Bike", Rate = 94000}
            };

            //Commented for strongly typed views 
            //Remove the below comment and remove the products object from view to remove strongly typed views.

            //ViewBag.products = products;
            return View(products);
        }

        public ActionResult Details(int id)
        {
            List<Product> products = new List<Product>()
            {
                new Product { ProductId  = 101, ProductName = "AC", Rate = 45000},
                new Product { ProductId  = 102, ProductName = "Mobile", Rate = 38000},
                new Product { ProductId  = 103, ProductName = "Bike", Rate = 94000}
            };

            Product matchingProduct = null;
            foreach (var item in products)
            {
                if (item.ProductId == id)
                {
                    matchingProduct = item;
                }
            }

            //Commented for strongly typed views 
            //Remove the below comment and remove the products object from view to remove strongly typed views.

            //ViewBag.MatchingProduct = matchingProduct;
            return View(matchingProduct);
        }

        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// CReated method is defined for the post method when the action button is submitted
        /// </summary>
        /// <param name="product">Product class object</param>
        /// <returns>View</returns>

        /*
         * Http post method is used when the form is submitted to the server
         */
        [HttpPost]
        public ActionResult Create([Bind(Include ="ProductId,ProductName")]Product product)
        {
            return View();
        }
    }
}