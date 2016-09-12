using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM.Controllers
{
    public class HomeController : Controller
    {
        // Get /home/index
        public ActionResult Index()
        {
            return View();
        }

        //Get /home/about
        public ActionResult About()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having trouble? Send us a message.";
            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            // TODO: send message to HQ
            ViewBag.TheMessage = "Thanks, we got your message!";
            return View();
        }


        // Get request
        // can use query string start with ? such as serial?letterCase=lower if no parameter define at route
        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVCATM1";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }

            // different actionresult return type
            //return Json(new { name = "serial", value = serial}, JsonRequestBehavior.AllowGet);
            //return new HttpStatusCodeResult(403);
            //return RedirectToAction("Index");
            return Content(serial);


        }
    }
}