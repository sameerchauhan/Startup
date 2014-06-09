using Domain;

namespace Repository
{
    public interface IUnitOfWork
    {
        IDashBoardRepository DashBoardRepository { get; }
    }
}