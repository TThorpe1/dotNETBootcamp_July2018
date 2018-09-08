using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstASPAppJuly2018.Models;


namespace FirstASPAppJuly2018.Controllers
{
    public class HomeController : Controller
    {
        // Index is the action name 
        public ActionResult Index()
        {
            // returning a view called Index 
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

        public ActionResult ThingsILike()
        {
            return View();

        }

        public ActionResult ProgLangs()
        {
            return View();

        }

        public ActionResult Signup()
        {
            return View(); 
        }

        public ActionResult AddUser(UserInfo newUser)
        {
            // ToDo: validation!!!!!! 

            if (ModelState.IsValid)
            {
                // ToDo: Send the data to the DB

                // confirmation, or maybe send to the Index page

                //ViewData["ConfMessage"] = "Thanks " + newUser.FirstName;

                ViewBag.ConfMessage = "Thanks " + newUser.FirstName;

                return View("Confirm");
            }

            else
            {   
                return View("Error");
            }
        }
    }
}