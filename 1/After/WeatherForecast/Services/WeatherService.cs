using WeatherForecast.Models;

namespace WeatherForecast.Services
{

    public class WeatherService : IWeatherService
    {
        public WeatherModel GetCurrentWeather()
        {
            return new WeatherModel { CurrentWeather = "Sunny" };
        }
    }
}