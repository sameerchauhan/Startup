using System;
using Repository;

namespace Web.API.Tests
{
    public class EmployeesController
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void GetEmployees(int pageSize)
        {
            _unitOfWork.EmployeeRepository.GetEmployees(pageSize);
        }
    }
}