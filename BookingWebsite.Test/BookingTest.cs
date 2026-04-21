using BookingWebsite.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace BookingWebsite.Test
{
    public class BookingTest
    {
        [Fact]
        public void Test1()
        {
            var controller = new HomeController();

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void App_Starts_And_Returns_View()
        {
            // Arrange
            var controller = new BookingWebsite.Controllers.HomeController(null); 

            // Act
            var result = controller.Index();

            // Assert
            Assert.NotNull(result);
        }
    }
}