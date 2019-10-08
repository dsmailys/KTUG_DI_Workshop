using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Shouldly;
using WeatherForecast.Controllers;
using WeatherForecast.Models;
using WeatherForecast.Services;
using Xunit;

namespace WeatherForecastTests.Controllers
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_WhenInvoced_ShouldUseWeatherModelFromWeatherService ()
        {
            var logger = new Mock<ILogger<HomeController>>();

            var weatherModel = new WeatherModel { CurrentWeather = "kind of a nice weather" };
            var weatherService = new Mock<IWeatherService> ();
            weatherService.Setup (s => s.GetCurrentWeather()).Returns (weatherModel);
            
            var controller = new HomeController (logger.Object, weatherService.Object);

            var result = controller.Index ();
            var viewResult = result.ShouldBeOfType <ViewResult>();
            viewResult.Model.ShouldBe (weatherModel);
        }
    }
}
