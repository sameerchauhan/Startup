using System.Collections.Generic;

namespace Web.Services
{
    public class DashBoardService : IDashBoardService
    {
        public IEnumerable<DashBoardItemDto> GetDashBoardItems()
        {
            return new List<DashBoardItemDto>();
        }
    }
}