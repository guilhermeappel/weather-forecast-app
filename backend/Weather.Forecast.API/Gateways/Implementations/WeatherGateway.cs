using System.Globalization;
using Weather.Forecast.API.Constants;
using Weather.Forecast.API.DTOs.Gateways.Weather;
using Weather.Forecast.API.Extensions;
using Weather.Forecast.API.Gateways.Interfaces;

namespace Weather.Forecast.API.Gateways.Implementations;

public class WeatherGateway : IWeatherGateway
{
    private readonly HttpClient _httpClient;

    public WeatherGateway(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient(ConfigurationConstants.HttpConfiguration.WEATHER_API);
    }

    public async Task<ForecastResponseDto?> GetWeatherForecastAsync(double latitude, double longitude)
    {
        try
        {
            var formattedLatitude = latitude.ToString("F3", CultureInfo.InvariantCulture);
            var formattedLongitude = longitude.ToString("F3", CultureInfo.InvariantCulture);

            var httpResponseMessage = await _httpClient.GetAsync($"/points/{formattedLatitude},{formattedLongitude}");
            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                // Log the response status code and content for debugging purposes.
                // Example: _logger.LogError($"Failed to fetch weather data. Status: {response.StatusCode}. Content: {await response.Content.ReadAsStringAsync()}");
                return null;
            }

            var stringContent = await httpResponseMessage.Content.ReadAsStringAsync();
            var weatherResponseDto = stringContent.DeserializeCaseInsensitive<WeatherResponseDto>();

            // Using the weatherData, fetch the 7-day forecast
            var forecastUrl = weatherResponseDto?.Properties?.Forecast;
            if (string.IsNullOrEmpty(forecastUrl))
            {
                // Log the issue: Forecast URL is missing.
                // Example: _logger.LogError("Forecast URL is missing from the response.");
                return null;
            }

            httpResponseMessage = await _httpClient.GetAsync(forecastUrl);
            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                // Log the response status code and content for debugging purposes.
                // Example: _logger.LogError($"Failed to fetch forecast data. Status: {response.StatusCode}. Content: {await response.Content.ReadAsStringAsync()}");
                return null;
            }

            stringContent = await httpResponseMessage.Content.ReadAsStringAsync();
            return stringContent.DeserializeCaseInsensitive<ForecastResponseDto>();
        }
        catch (HttpRequestException ex)
        {
            // Handle exceptions related to the HTTP request (e.g., network issues, timeouts).
            // Log the exception.
            // Example: _logger.LogError(ex, "Error occurred while trying to fetch weather data.");
            return null;
        }
        catch (Exception ex)
        {
            // Handle other unexpected issues.
            // Log the exception.
            // Example: _logger.LogError(ex, "An unexpected error occurred.");
            return null;
        }
    }
}
