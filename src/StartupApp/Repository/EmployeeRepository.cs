using System;
using System.Collections.Generic;
using Repository.EF;

namespace Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly GenericRepository<Employee> _genericRepository;

        public EmployeeRepository(GenericRepository<Employee> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public IEnumerable<Employee> GetEmployees(int pageSize)
        {
            return _genericRepository.Get(null, null, string.Empty, pageSize);
        }
    }
}