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
            var (latitude, longitude) = await GetCoordinatesFromZipCode(zipCode);

            var url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&current_weather=true&temperature_unit=fahrenheit";

            var response = await _httpClient.GetFromJsonAsync<WeatherData>(url);
            return response;
        }

        private async Task<(double latitude, double longitude)> GetCoordinatesFromZipCode(string zipCode)
        {
            var url = $"https://geocoding-api.open-meteo.com/v1/search?name={zipCode}&count=1&language=en&format=json";
            var response = await _httpClient.GetFromJsonAsync<GeocodingResponse>(url);

            return (response.results[0].latitude, response.results[0].longitude);
        }
    }
}


