using System.Collections.Generic;

namespace Web.UI.Models
{
    public class HomeModel
    {
        public IEnumerable<DashBoardItemModel> DashboardItems { get; set; }
        public bool DashBoardEnabled { get; set; }
    }
}