using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using FeatureToggle.Toggles;
using StartupApp.Tests.Controllers;

namespace StartupApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDashBoardService _service;

        public HomeController(IDashBoardService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            var myAwesomeFeature = new MyAwesomeFeature();
            var model = new HomeModel();

            if (myAwesomeFeature.FeatureEnabled)
            {
                Mapper.CreateMap<DashBoardItemDto, DashBoardItem>();
                var dashBoardItems = Mapper.Map<IEnumerable<DashBoardItem>>(_service.GetDashBoardItems());
                model.DashboardItems = dashBoardItems;
            }
            return View(model);
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

    public class HomeModel
    {
        public IEnumerable<DashBoardItem> DashboardItems { get; set; }
    }

    public class DashBoardItem
    {
        public string Name { get; set; }
    }

    
    public class MyAwesomeFeature : SimpleFeatureToggle { }
}