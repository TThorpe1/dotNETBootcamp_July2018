using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestCookies.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string Unit = "";
            string Temp = "";
            if (Request.Cookies["Unit"] == null)
            {
                // get temp in F
                Temp = "75";
            }
            else// the cookie exists 
            {
             
                Unit = Request.Cookies["Unit"].Value;

                if (Unit == "C")
                    Temp = "25";
                else
                    Temp = "75";

            }
           

            ViewBag.Temp = Temp+" "+ Unit;

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
            //1. Get the data
            // Very first request 
            HttpCookie newCookie;
            if (Request.Cookies["Num"] == null)
            {
                newCookie = new HttpCookie("Num", "0");
                newCookie.Expires = new DateTime(2020, 1, 1);
                Num = 0;
                //DateTime newDate =DateTime.Now.AddMonths(1);
                //newCookie.Expires = new DateTime(newDate.Year, newDate.Month, newDate.Day);
            }
            else// the cookie exists 
            {
                newCookie = Request.Cookies["Num"];
                Num = int.Parse(Request.Cookies["Num"].Value);

            }
            //2. Adjust 

            Num++;
            //3. Save the data back 
            newCookie.Value = Num.ToString();
            
            Response.Cookies.Add(newCookie);// sending the cookie back to the client 

            ViewBag.Num = Num;

            return View("Contact");

        }

        public ActionResult ChangeUnit(string Unit)
        {

            //1. Get the data
            // Very first request 
            HttpCookie newCookie;
            if (Request.Cookies["Unit"] == null)
            {
                newCookie = new HttpCookie("Unit", "F");
                
               
            }
            else// the cookie exists 
            {
                newCookie = Request.Cookies["Unit"];
              

            }
           
            //Save the data back 
            newCookie.Value = Unit;
            newCookie.Expires = new DateTime(2020, 1, 1);
            Response.Cookies.Add(newCookie);// sending the cookie back to the client 



            return RedirectToAction("Index");




        }
    }
}