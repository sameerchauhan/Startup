using System.Collections.Generic;

namespace StartupApp.Tests.Controllers
{
    public interface IDashBoardService
    {
        IEnumerable<DashBoardItemDto> GetDashBoardItems();
    }
}