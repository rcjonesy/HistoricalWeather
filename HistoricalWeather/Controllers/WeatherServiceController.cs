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

    [HttpGet("{zipCode}")]
    public async Task<ActionResult<WeatherData>> GetCurrentWeatherAsync(string zipCode)
    {
        var weather = await _weatherService.GetCurrentWeatherAsync(zipCode);
        return Ok(weather);
    }
}
