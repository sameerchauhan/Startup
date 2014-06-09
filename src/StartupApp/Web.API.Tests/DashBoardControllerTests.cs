using System.Collections;
using System.Collections.Generic;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository;
using Web.Services.Controllers;
using Web.Services.Models;

namespace Web.API.Tests
{
    [TestClass]
    public class DashBoardControllerTests
    {
        [TestMethod]
        public void ShouldReturnAListOfDashboardItemsToView()
        {
            var expectedItems = new List<DashBoardItem> { new DashBoardItem() };
            var mock = new Mock<IDashBoardRepository>();
            mock.Setup(r => r.Get()).Returns(expectedItems);
            var controller = new DashboardController(mock.Object);

            var items = controller.Get();

            Assert.AreEqual(expectedItems.Count, ((IList)items).Count);
        }
    }  
}
