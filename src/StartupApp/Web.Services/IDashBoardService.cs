using System.Collections.Generic;

namespace Web.Services
{
    public interface IDashBoardService
    {
        IEnumerable<DashBoardItemDto> GetDashBoardItems();
    }
}