using WeatherForecast.Models;

namespace WeatherForecast.Services
{
    public class WeatherService
    {
        public WeatherModel GetCurrentWeather() {
            return new WeatherModel { CurrentWeather = "Sunny" };
        }
    }
}