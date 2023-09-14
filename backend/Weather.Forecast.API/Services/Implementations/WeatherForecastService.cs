using Weather.Forecast.API.DTOs.Gateways.Weather;
using Weather.Forecast.API.Gateways.Interfaces;
using Weather.Forecast.API.Services.Interfaces;

namespace Weather.Forecast.API.Services.Implementations;

public class WeatherForecastService : IWeatherForecastService
{
    private readonly IGeocodingGateway _geocodingGateway;
    private readonly IWeatherGateway _weatherGateway;

    public WeatherForecastService(IGeocodingGateway geocodingGateway, IWeatherGateway weatherGateway)
    {
        _geocodingGateway = geocodingGateway;
        _weatherGateway = weatherGateway;
    }

    public async Task<IReadOnlyCollection<PeriodDto>?> GetWeatherForAddressAsync(string address)
    {
        if (string.IsNullOrEmpty(address))
        {
            throw new ArgumentException("Address cannot be null or empty.", nameof(address));
        }

        try
        {
            var geocodingResponseDto = await _geocodingGateway.GeocodeSingleLineAddressAsync(address);
            var coordinatesDto = geocodingResponseDto?.Result?.AddressMatches?.FirstOrDefault()?.Coordinates;
            if (coordinatesDto == null)
            {
                // Log the event. Adjust as per your logging mechanism.
                // Example: _logger.LogWarning($"Unable to fetch coordinates for the provided address: {address}");
                return null; // Return null or a default value if you don't want to throw an exception.
            }

            var forecastResponseDto = await _weatherGateway.GetWeatherForecastAsync(coordinatesDto.Latitude, coordinatesDto.Longitude);
            var periodsDtos = forecastResponseDto?.Properties?.Periods;
            if (periodsDtos == null || !periodsDtos.Any())
            {
                // Log the event. Adjust as per your logging mechanism.
                // Example: _logger.LogWarning($"Unable to fetch weather for the provided coordinates: Latitude: {coordinatesDto.Latitude}, Longitude: {coordinatesDto.Longitude}");
                return null; // Return null or a default value if you don't want to throw an exception.
            }

            return periodsDtos;
        }
        catch (Exception ex)
        {
            // Handle other unexpected issues.
            // Log the exception. Adjust as per your logging mechanism.
            // Example: _logger.LogError(ex, $"An unexpected error occurred while fetching weather for address: {address}");
            return null; // Return null or a default value in case of errors.
        }
    }
}