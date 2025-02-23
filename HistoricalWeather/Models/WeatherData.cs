using System.Text.Json.Serialization;

namespace HistoricalWeather.Models
{
    public class WeatherData
    {
        [JsonPropertyName("current_weather")]
        public CurrentWeather? Currentweather { get; set; }
    }
}
