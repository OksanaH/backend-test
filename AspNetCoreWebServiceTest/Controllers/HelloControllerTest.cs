using Xunit;
using AspNetCoreWebService.Controllers;
using AspNetCoreWebService.Providers;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AspNetCoreWebServiceTest.Controllers
{
    public class RandomNumberControllerTest
    {
        private readonly RandomNumberProvider randomNumberProvider;

        public RandomNumberControllerTest()
        {
            randomNumberProvider = new RandomNumberProvider();
        }

        [Fact]
        public void ResponseContainsCorrectString()
        {
            RandomNumberController controller = new RandomNumberController(randomNumberProvider);
            var response = controller.Get() as OkObjectResult;
            Assert.Contains("Your random number is ", response.Value.ToString());
        }

        [Fact]
        public void ResponseHasStatus200()
        {
            RandomNumberController controller = new RandomNumberController(randomNumberProvider);
            var response = controller.Get() as OkObjectResult;
            Assert.Equal(200, response.StatusCode);
        }
    }
}
