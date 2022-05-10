using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherWeb.Entities;

namespace WeatherWeb.Services
{
    public interface IWeatherApiService
    {
        Task<IReadOnlyCollection<WeatherForecast>> GetAvailableWeatherForecastAsync();
    }
}
