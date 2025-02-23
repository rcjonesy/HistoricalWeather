using HistoricalWeather.Interfaces;
using HistoricalWeather.Models;

namespace HistoricalWeather.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;
        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherData> GetCurrentWeatherAsync(string zipCode)
        {
            var latitude = 36.1627;
            var longitude = -86.7816;

            var url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&current_weather=true";

            var response = await _httpClient.GetFromJsonAsync<WeatherData>(url);
            return response;
        }
    }
}


