using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestRazorJuly2018.Controllers
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

        public ActionResult SearchProducts(string productName)
        {
            // db for products 
            string[] products = { "Coke", "Water", "Coffee", "Ruffles Chips","Cold Ice Tea"};

            string[] results = products.Where(x => x.ToLower().Contains(productName.ToLower())).ToArray();

            ViewBag.SearchResults = results;

            return View();

        }
    }
}