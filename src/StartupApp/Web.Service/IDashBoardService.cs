using System.Collections.Generic;
using Web.Services;

namespace Web.Service
{
    public interface IDashBoardService
    {
        IEnumerable<DashBoardItemDto> GetDashBoardItems();
    }
}