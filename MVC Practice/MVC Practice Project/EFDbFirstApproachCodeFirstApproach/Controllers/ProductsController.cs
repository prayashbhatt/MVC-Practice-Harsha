using EFDbFirstApproachCodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDbFirstApproach.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products

        //public ActionResult Index()
        //{
        //    EFDBFirstDatabaseEntities eFDBFirstDatabaseEntities = new EFDBFirstDatabaseEntities();
        //    //List<Product> products = eFDBFirstDatabaseEntities.Products.ToList(); //Commented for passing the where condition.
        //    List<Product> products = eFDBFirstDatabaseEntities.Products.Where(Prd => Prd.CategoryID == 1 && Prd.Price >= 50000).ToList();
        //    return View(products);
        //}

        CompanyDbContext eFDBFirstDatabaseEntities = new CompanyDbContext();

        public ActionResult Index(string search = "", string SortColumn = "ProductName", string IconClass = "fa-sort-asc" ,int PageNo= 1)
        {
            ViewBag.search = search;
            List<Product> products = eFDBFirstDatabaseEntities.Products.Where(prod => prod.ProductName.Contains(search)).ToList();

            #region Sorting

            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (ViewBag.SortColumn == "ProductID")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                {
                    products = products.OrderBy(prod => prod.ProductID).ToList();
                }
                else
                {
                    products = products.OrderByDescending(prod => prod.ProductID).ToList();
                }
            }
            else if (ViewBag.SortColumn == "ProductName")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                {
                    products = products.OrderBy(prod => prod.ProductName).ToList();
                }
                else
                {
                    products = products.OrderByDescending(prod => prod.ProductName).ToList();
                }
            }
            else if (ViewBag.SortColumn == "Price")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                {
                    products = products.OrderBy(prod => prod.Price).ToList();
                }
                else
                {
                    products = products.OrderByDescending(prod => prod.Price).ToList();
                }
            }
            else if (ViewBag.SortColumn == "DateOfPurchase")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                {
                    products = products.OrderBy(prod => prod.DateOfPurchase).ToList();
                }
                else
                {
                    products = products.OrderByDescending(prod => prod.DateOfPurchase).ToList();
                }
            }
            else if (ViewBag.SortColumn == "AvailabilityStatus")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                {
                    products = products.OrderBy(prod => prod.AvailabilityStatus).ToList();
                }
                else
                {
                    products = products.OrderByDescending(prod => prod.AvailabilityStatus).ToList();
                }
            }
            else if (ViewBag.SortColumn == "CategoryID")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                {
                    products = products.OrderBy(prod => prod.CategoryID).ToList();
                }
                else
                {
                    products = products.OrderByDescending(prod => prod.CategoryID).ToList();
                }
            }
            else if (ViewBag.SortColumn == "BrandID")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                {
                    products = products.OrderBy(prod => prod.BrandID).ToList();
                }
                else
                {
                    products = products.OrderByDescending(prod => prod.BrandID).ToList();
                }
            }

            #endregion


            #region Paging

            int NoOfRecordsPerPage = 5;
            int NoOfPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(products.Count)/Convert.ToDouble(NoOfRecordsPerPage)));
            int NoOfRecordsToSkip = (PageNo - 1) * NoOfRecordsPerPage;
            ViewBag.PageNo = PageNo;
            ViewBag.NoOfPages = NoOfPages;
            products = products.Skip(NoOfRecordsToSkip).Take(NoOfRecordsPerPage).ToList();

            #endregion

            return View(products);
        }

        public ActionResult Details(long id)
        {
            //List<Product> products = eFDBFirstDatabaseEntities.Products.ToList(); //Commented for passing the where condition.
            Product products = eFDBFirstDatabaseEntities.Products.Where(Prd => Prd.ProductID == id).FirstOrDefault();
            return View(products);
        }

        public ActionResult Create()
        {
            ViewBag.Categories = eFDBFirstDatabaseEntities.Categories.ToList();
            ViewBag.Brands = eFDBFirstDatabaseEntities.Brands.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];
                var imgBytes = new Byte[file.ContentLength + 1];
                file.InputStream.Read(imgBytes, 0, file.ContentLength);
                var base64String = Convert.ToBase64String(imgBytes, 0, imgBytes.Length);
                product.Photo = base64String;
            }
            eFDBFirstDatabaseEntities.Products.Add(product);
            eFDBFirstDatabaseEntities.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult Edit(long id)
        {
            Product existingProduct = eFDBFirstDatabaseEntities.Products.Where(Prod => Prod.ProductID == id).FirstOrDefault();
            ViewBag.Categories = eFDBFirstDatabaseEntities.Categories.ToList();
            ViewBag.Brands = eFDBFirstDatabaseEntities.Brands.ToList();
            return View(existingProduct);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            Product existingProduct = eFDBFirstDatabaseEntities.Products.Where(Prod => Prod.ProductID == product.ProductID).FirstOrDefault();
            existingProduct.ProductName = product.ProductName;
            existingProduct.Price = product.Price;
            existingProduct.DateOfPurchase = product.DateOfPurchase;
            existingProduct.CategoryID = product.CategoryID;
            existingProduct.BrandID = product.BrandID;
            existingProduct.AvailabilityStatus = product.AvailabilityStatus;
            existingProduct.Active = product.Active;
            eFDBFirstDatabaseEntities.SaveChanges();
            return RedirectToAction("index", "Products");
        }

        public ActionResult Delete(long id)
        {
            Product existingproduct = eFDBFirstDatabaseEntities.Products.Where(ProdDel => ProdDel.ProductID == id).FirstOrDefault();
            return View(existingproduct);
        }

        [HttpPost]
        public ActionResult Delete(long id, Product product)
        {
            Product existingProduct = eFDBFirstDatabaseEntities.Products.Where(prodDel => prodDel.ProductID == id).FirstOrDefault();
            eFDBFirstDatabaseEntities.Products.Remove(existingProduct);
            eFDBFirstDatabaseEntities.SaveChanges();
            return RedirectToAction("index", "products");
        }
    }
}