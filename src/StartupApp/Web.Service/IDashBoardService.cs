using System.Collections.Generic;
using Web.Services.Models;

namespace Web.Service
{
    public interface IDashBoardService
    {
        IEnumerable<DashBoardItemDto> GetDashBoardItems();
    }
}