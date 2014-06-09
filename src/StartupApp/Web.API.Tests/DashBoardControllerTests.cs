using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
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
            var uow = new Mock<IUnitOfWork>();      
            uow.Setup(m => m.DashBoardRepository.Get()).Returns(expectedItems);
            var controller = new DashboardController(uow.Object);

            var items = controller.GetDashboard();

            Assert.AreEqual(expectedItems.Count, ((IList)items).Count);
        }
    }  
}
