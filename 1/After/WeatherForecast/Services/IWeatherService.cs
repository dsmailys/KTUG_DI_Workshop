using WeatherForecast.Models;

namespace WeatherForecast.Services
{
    public interface IWeatherService
    {
        WeatherModel GetCurrentWeather();
    }
}