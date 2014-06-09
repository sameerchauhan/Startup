using System.Collections.Generic;
using Web.Services.Models;

namespace Web.Service
{
    public class DashBoardService : IDashBoardService
    {
        public IEnumerable<DashBoardItemDto> GetDashBoardItems()
        {
            return new List<DashBoardItemDto>();
        }
    }
}