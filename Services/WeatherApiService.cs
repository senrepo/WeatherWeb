using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherWeb.Entities;
using WeatherWeb.Services.Extensions;

namespace WeatherWeb.Services
{
    public class WeatherApiService : IWeatherApiService
    {
        private readonly HttpClient _httpClient;

        public WeatherApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IReadOnlyCollection<WeatherForecast>> GetAvailableWeatherForecastAsync()
        {
            var response = await _httpClient.GetAsync("weatherforecast");
            return await response.ReadContentAs<List<WeatherForecast>>();
        }
    }
}
