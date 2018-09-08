using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestEntityFrameworkJuly2018.Models; //1 

namespace TestEntityFrameworkJuly2018.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {   //2. Create an object that will represent the ORM
            northwindEntities NorthwindORM = new northwindEntities();

            ViewBag.CustomerList = NorthwindORM.Customers.ToList();
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
    }
}