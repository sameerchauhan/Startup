using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Web.Service;
using Web.Services.Models;
using Web.UI.Models;

namespace Web.UI.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public ActionResult Index(int numberOfEmployees)
        {
            AutoMapper.Mapper.CreateMap<EmployeeListDto, EmployeeListModel>();
            var model = Mapper.Map<IEnumerable<EmployeeListModel>>(_employeeService.GetEmployees(numberOfEmployees));
            return View(model);
        }
    }
}