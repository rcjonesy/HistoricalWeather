using HistoricalWeather.Interfaces;
using HistoricalWeather.Models;
using Microsoft.AspNetCore.Mvc;

namespace HistoricalWeather.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherServiceController : ControllerBase
{
    private readonly IWeatherService _weatherService;
    public WeatherServiceController(IWeatherService WeatherService)
    {
        _weatherService = WeatherService;
    }

    [HttpGet("current/{zipCode}")]
    public async Task<ActionResult<WeatherData>> GetCurrentWeatherAsync(string zipCode)
    {
        var currentWeather = await _weatherService.GetCurrentWeatherAsync(zipCode);
        return Ok(currentWeather);
    }

    [HttpGet("historical/{zipCode}/{startDate}/{endDate}")]
    public async Task<ActionResult<WeatherData>> GetHistoricalWeatherAsync(string zipCode, DateTime startDate, DateTime endDate)
    {
        var historicalWeather = await _weatherService.GetHistoricalWeatherAsync(zipCode, startDate, endDate);
            return Ok(historicalWeather);
    }
}
