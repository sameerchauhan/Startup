using System.Collections.Generic;
using Web.UI.Models;

namespace Web.UI.Controllers
{
    public class HomeModel
    {
        public IEnumerable<DashBoardItemModel> DashboardItems { get; set; }
        public bool DashBoardEnabled { get; set; }
    }
}