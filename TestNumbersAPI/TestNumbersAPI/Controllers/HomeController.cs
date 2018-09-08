using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using System.Configuration;

namespace TestNumbersAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
HttpWebRequest apiRequest =
 WebRequest.CreateHttp("https://numbersapi.p.mashape.com/1492/year?fragment=true&json=true");
            apiRequest.Headers.Add("X-Mashape-Key", ConfigurationManager.AppSettings["X-Mashape-Key"]);// used to add keys 
            apiRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";

            HttpWebResponse apiResponse = (HttpWebResponse)apiRequest.GetResponse();
            if (apiResponse.StatusCode == HttpStatusCode.OK)// if we got a status ==200 
            {
                // get the data and then parse it 
                StreamReader responseData = new StreamReader(apiResponse.GetResponseStream());

                string trivia = responseData.ReadToEnd();// reads the data from the response 

                // ToDo: parse the Json data
                JObject jsonTrivia = JObject.Parse(trivia);

                ViewBag.trivia = jsonTrivia["text"];
                ViewBag.triviaDate = jsonTrivia["date"];

            }

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