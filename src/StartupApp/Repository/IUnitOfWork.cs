using Domain;

namespace Repository
{
    public interface IUnitOfWork
    {
        GenericRepository<DashBoardItem> DashBoardRepository { get; }
    }
}