using Weather.Forecast.API.DTOs.Gateways.Weather;

namespace Weather.Forecast.API.Services.Interfaces;

public interface IWeatherForecastService
{
    Task<IReadOnlyCollection<PeriodDto>?> GetWeatherForAddressAsync(string address);
}