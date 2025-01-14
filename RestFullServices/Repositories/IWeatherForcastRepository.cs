﻿using Domain;
using Shared.Enums;

namespace Repositories
{
    public interface IWeatherForcastRepository
    {
        Task<IEnumerable<WeatherForecast>> GetWeather();
        Task<WeatherForecast> GetWeather(int id);
        Task<ApplicationResult> AddWeather(WeatherForecast weatherForecast);
        Task<ApplicationResult> UpdateWeather(WeatherForecast weatherForecast);
        Task<ApplicationResult> DeleteWeather(int id);
    }
}