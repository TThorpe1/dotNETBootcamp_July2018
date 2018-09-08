using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestStateManagementJuly2018.Controllers
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

        int Num = 0; 
        public ActionResult Increment()
        {
            //1. Get the value from TempData 
            // if this is the first request 
            if (TempData["Num"] == null) {
                TempData.Add("Num", 0);
            }

            Num = (int)TempData["Num"];
            
            //2. Adjust the value 
            Num++;

            //3. Save the value back into TempData
            TempData["Num"] = Num;

            ViewBag.Num = Num;
            return View("Contact");
        }
    }
}