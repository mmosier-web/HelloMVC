using System;
using HelloMVC.Controller;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace HelloMVC.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_ViewResult()
        {
            var controller = new HomeController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
