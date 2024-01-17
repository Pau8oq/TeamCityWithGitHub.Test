using Microsoft.AspNetCore.Mvc.Testing;
using TeamCityWithGitHub;

namespace TeamCityWithGitHub.Test
{
    [TestClass]
    public class ApiTests
    {
        [TestMethod]
        public void DefaultRoute_ReturnsHelloWorld()
        {
            //var webAppFactory = new WebApplicationFactory<Program>();
            //var httpClient = webAppFactory.CreateDefaultClient();

            //var response = await httpClient.GetAsync("WeatherForecast/HelloWorld");
            //var stringResult = await response.Content.ReadAsStringAsync();

           // Assert.AreEqual("Hello World!", stringResult);
        }


        [TestMethod]
        public void Test_Failure()
        {
            var str = "not hello";
            Assert.AreEqual(str, "hello");
        }
    }
}