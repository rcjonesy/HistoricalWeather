using HistoricalWeather.Models;

namespace HistoricalWeather.Interfaces
{
    public interface IWeatherService
    {
        Task<WeatherData> GetCurrentWeatherAsync(string zipCode);
        Task<WeatherData> GetHistoricalWeatherAsync(string zipCode, DateTime startDate, DateTime endDate);
    }
}
