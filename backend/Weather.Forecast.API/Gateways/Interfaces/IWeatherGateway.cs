using Weather.Forecast.API.DTOs.Gateways.Weather;

namespace Weather.Forecast.API.Gateways.Interfaces;

public interface IWeatherGateway
{
    Task<ForecastResponseDto?> GetWeatherForecastAsync(double latitude, double longitude);
}