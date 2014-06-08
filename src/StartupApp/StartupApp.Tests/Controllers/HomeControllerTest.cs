﻿using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StartupApp.Controllers;

namespace StartupApp.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private HomeController _controller;
        private Mock<IDashBoardService> _service;

        [TestInitialize]
        public void GivenUserHasBeenRedirected()
        {
            _service = new Mock<IDashBoardService>();
            _controller = new HomeController(_service.Object);

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None); // Add an Application Setting.
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None); // Add an Application Setting.
            config.AppSettings.Settings.Remove("FeatureToggle.MyAwesomeFeature");
            config.AppSettings.SectionInformation.ForceSave = true;
            config.Save(ConfigurationSaveMode.Full);
        }

       
        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController(null);

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController(null);

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ShouldShowHumanResourceDashBoardItem()
        {
            SetFeatureToogle(true);
            var di = new DashBoardItem{Name = "Name"};
            _service.Setup(s => s.GetDashBoardItems()).Returns(new List<DashBoardItemDto>(){new DashBoardItemDto{Name="Name"}});
            
            var model = (HomeModel)((ViewResult) _controller.Index()).Model ;
            
            Assert.AreEqual(di.Name, ((IList<DashBoardItem>)model.DashboardItems)[0].Name);
        }

        [TestMethod]
        public void ShouldNotShowHumanResourceDashBoardItemWhenFeatureDisabled()
        {
            SetFeatureToogle(false);
            _service.Setup(s => s.GetDashBoardItems()).Returns(new List<DashBoardItemDto>() { new DashBoardItemDto { Name = "Name" } });

            _controller.Index();
            
            _service.Verify(s => s.GetDashBoardItems(), Times.Never);
        }

        private static void SetFeatureToogle(bool enabled)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None); // Add an Application Setting.
            config.AppSettings.Settings.Add("FeatureToggle.MyAwesomeFeature", enabled.ToString());
            config.AppSettings.SectionInformation.ForceSave = true;
            config.Save(ConfigurationSaveMode.Full);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
