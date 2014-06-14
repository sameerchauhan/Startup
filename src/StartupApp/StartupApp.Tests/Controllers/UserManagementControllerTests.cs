using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace StartupApp.Tests.Controllers
{
    [TestClass]
    public class UserManagementControllerTests
    {
        [TestMethod]
        public void ShouldCallServiceToShowFirst20Users()
        {
            var list = new List<UserDto>();
            var userManagementService = new Mock<IUserManagementService>();
            userManagementService.Setup(ums => ums.GetUsers(20)).Returns(list);
            var controller = new UserManagementController(userManagementService.Object);

            userManagementService.Verify(ums => ums.GetUsers(20), Times.Once);

        }
    }

    public class UserManagementController
    {
        public UserManagementController(IUserManagementService userManagementService)
        {
            throw new NotImplementedException();
        }
    }

    public interface IUserManagementService
    {
        IEnumerable<UserDto> GetUsers(int pageSize);
    }

    public class UserDto
    {
    }
}
