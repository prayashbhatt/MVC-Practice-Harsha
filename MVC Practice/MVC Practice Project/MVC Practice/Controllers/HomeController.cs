using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Practice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View("OurCompanyProducts");
        }
        public ActionResult Contact()
        {
            ViewBag.Tollfree = "123-123-123";
            return View();
        }


        /*
         Content Type Demo Function
         */
        public ActionResult GetEmpName(int EmpId)
        {
            var employees = new[] {
                new {EmpId = 1,EmpName = "Scott", Salary = 8000 },
                new {EmpId = 2,EmpName = "Smith",Salary = 2540 },
                new {EmpId = 3,EmpName = "Allen",Salary =9400 },
            };

            string MatchEmpName = String.Empty;
            foreach (var item in employees)
            {
                if (item.EmpId == EmpId)
                {
                    MatchEmpName = item.EmpName;
                }
            }
            return Content(MatchEmpName,"text/plain"); 
        }

        //File Opening Demo
        public ActionResult GetPaySlip(int EmpId)
        {
            String FileName = "~/PaySlipFolder/Payslip" + EmpId + ".pdf";
            return File(FileName,"application/pdf");
        }

        //Redirect to url result
        public ActionResult GetEmpFbPage(int EmpId)
        {
            var employees = new[] {
                new {EmpId = 1,EmpName = "Scott", Salary = 8000 },
                new {EmpId = 2,EmpName = "Smith",Salary = 2540 },
                new {EmpId = 3,EmpName = "Allen",Salary =9400 },
            };

            string MatchEmpName = String.Empty;
            String fbUrl = String.Empty;

            foreach (var item in employees)
            {
                if (item.EmpId == EmpId)
                {
                    fbUrl = "http://www.facebook.com/emp" + EmpId;
                }
            }

            if (fbUrl == null)
            {
                return Content("Invalid Emp ID");
            }
            else
            {
                return Redirect(fbUrl);
            }
            
            //return Redirect(fbUrl);
        }
    }
}