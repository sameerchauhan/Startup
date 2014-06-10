using System.Collections.Generic;
using System.Web.Http;
using AutoMapper;
using Repository;
using Repository.EF;
using Web.Services.Models;

namespace Web.Services.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<EmployeeListDto> Get()
        {
            return new List<EmployeeListDto>();
            //Mapper.CreateMap<Employee, EmployeeListDto>();
            //return Mapper.Map<IEnumerable<EmployeeListDto>>(_unitOfWork.EmployeeRepository.GetEmployees(pageSize));
        }
    }
}