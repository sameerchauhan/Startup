using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Security.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (!SecurityEnabled)
            {
                return Redirect("http://localhost:50426/");                
            }

            return View();
        }

        public bool SecurityEnabled { get; set; }

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