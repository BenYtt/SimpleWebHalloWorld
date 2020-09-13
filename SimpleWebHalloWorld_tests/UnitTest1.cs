using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleWebHalloWorld.Controllers;

namespace SimpleWebHalloWorld_tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void TestDetailsView()
        {
            
            var controller = new HomeController(null);

            var result = controller.Index() as ViewResult;
            
            Assert.AreEqual("Index", result.ViewName);

        }
    }
}
