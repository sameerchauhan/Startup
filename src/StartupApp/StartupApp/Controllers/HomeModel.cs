using System.Collections.Generic;

namespace Web.UI.Controllers
{
    public class HomeModel
    {
        public IEnumerable<DashBoardItem> DashboardItems { get; set; }
        public bool DashBoardEnabled { get; set; }
    }
}