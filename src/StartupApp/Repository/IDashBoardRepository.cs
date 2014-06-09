using System.Collections.Generic;
using Domain;

namespace Repository
{
    public interface IDashBoardRepository
    {
        IEnumerable<DashBoardItem> Get();
    }
}