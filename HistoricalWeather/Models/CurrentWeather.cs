using System.Text.Json.Serialization;

namespace HistoricalWeather.Models
{
    public class CurrentWeather
    {
        [JsonPropertyName("temperature")]
        public double Temperature { get; set; }
    }

}
