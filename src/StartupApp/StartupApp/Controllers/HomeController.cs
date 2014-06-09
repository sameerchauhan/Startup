using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Web.Services;
using Web.UI.Models;
using Web.UI.SampleFeatureToggles;

namespace Web.UI.Controllers
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
            var myAwesomeFeature = new DashBoardFeature();
            var model = new HomeModel();
            model.DashBoardEnabled = myAwesomeFeature.FeatureEnabled;
            if (model.DashBoardEnabled)
            {
                Mapper.CreateMap<DashBoardItemDto, DashBoardItemModel>();
                var dashBoardItems = Mapper.Map<IEnumerable<DashBoardItemModel>>(_service.GetDashBoardItems());
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
}