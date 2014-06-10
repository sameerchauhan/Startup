using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Web.Service;
using Web.Services.Models;
using Web.UI.Controllers;

namespace StartupApp.Tests.Controllers
{
    [TestClass]
    public class EmployeesControllerTests
    {
        [TestMethod]
        public void ShouldCallServiceToGetEmployees()
        {
            var mock = new Mock<IEmployeeService>();
            mock.Setup(m => m.GetEmployees(5)).Returns(new List<EmployeeListDto>());
            var controller = new EmployeesController(mock.Object);

            controller.Index(5);

            mock.Verify(v=>v.GetEmployees(5),Times.Once);
        }
    }
}