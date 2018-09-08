using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestHttpRequestJuly2018.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.BrowserName = Request.Browser.Browser;
            ViewBag.OS = Request.UserAgent;

            
            //if (Request.Browser.Browser == "Chrome")
            //{

            //    return View("ChromeDownload");
            //}

            //else if (Request.Browser.Browser == "FireFox")
            //{
            //    return View("FireFoxDownload");
            //}

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