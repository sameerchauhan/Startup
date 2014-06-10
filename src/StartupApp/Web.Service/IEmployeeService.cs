using System.Collections.Generic;

namespace Web.Service
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeListDto> GetEmployees(int i);
    }
}