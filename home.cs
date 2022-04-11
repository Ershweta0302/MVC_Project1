using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.test = 123;
            ViewBag.test1 = 2.3f ;
            ViewBag.test2 = "Hello World";
            ViewBag.test3 = DateTime.Now; 
            ViewBag.list = new List <String>()
                {
                "India","Us","Pak"
            };

            ViewData["test"] = 456;
            ViewData["test1"] = 11.2f;
            ViewData["test2"] = "Hello Sir";
            ViewData["test3"] = DateTime.Now;
            ViewData["listdata"] = new List<string>()
            {
                "Kanpur","Banars","Lucknow"
            };

            TempData["test"] = 789;
            TempData["test1"] = 2.8f;
            TempData["test2"] = "Good Afternoon Sir";
            TempData["listdata"] = new List<string>()
            {
                "Gorakhpur","Basti","Dilhi"
            };

            Session["test"] = 1011;
            Session["test1"]=90.1f;
            Session["test2"] = "Good Evening Sir";
            Session["listdata"] = new List<string>()
            {
                "Goa","Mumpai","Jaipur"
            };
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