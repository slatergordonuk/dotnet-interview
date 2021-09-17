using System.Web.Mvc;
using dotnet_interview;
using dotnet_interview.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotnet_interview.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
