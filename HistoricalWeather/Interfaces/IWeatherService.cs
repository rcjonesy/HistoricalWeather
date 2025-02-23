﻿namespace HistoricalWeather.Interfaces
{
    public interface IWeatherService
    {
        Task<WeatherData> GetCurrentWeatherAsync(string zipCode);
    }
}
