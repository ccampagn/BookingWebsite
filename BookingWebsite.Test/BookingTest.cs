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
    }
}