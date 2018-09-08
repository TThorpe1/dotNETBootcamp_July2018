using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAjax2018.Models;

namespace TestAjax2018.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public JsonResult SearchCustomerByCountry(string country)
        {
            // ORM 

            NorthwindEntities ORM = new NorthwindEntities();

            // search by country 

            List<Customer> Result=ORM.Customers.Where(c => c.Country.Contains(country)).ToList();

            // Retrun data as Json! 

            return Json(Result);

        }
    }
}