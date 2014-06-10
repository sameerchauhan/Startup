using System.Collections.Generic;
using Domain;
using Repository.EF;

namespace Repository
{
    public interface IUnitOfWork
    {
        IDashBoardRepository DashBoardRepository { get; }
        IEmployeeRepository EmployeeRepository { get; set; }
    }

    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees(int pageSize);
    }
}