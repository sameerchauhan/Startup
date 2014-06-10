using System.Collections.Generic;
using Web.Services.Models;

namespace Web.Service
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeListDto> GetEmployees(int i);
    }
}