using System.Collections.Generic;
using Repository.EF;

namespace Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees(int pageSize);
    }
}