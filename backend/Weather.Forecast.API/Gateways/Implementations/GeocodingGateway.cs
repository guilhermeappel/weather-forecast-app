using Weather.Forecast.API.Constants;
using Weather.Forecast.API.DTOs.Gateways.Geocodings;
using Weather.Forecast.API.Extensions;
using Weather.Forecast.API.Gateways.Interfaces;

namespace Weather.Forecast.API.Gateways.Implementations;

public class GeocodingGateway : IGeocodingGateway
{
    private readonly HttpClient _httpClient;

    public GeocodingGateway(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient(ConfigurationConstants.HttpConfiguration.GEOCODING_API);
    }

    public async Task<GeocodingResponseDto?> GeocodeSingleLineAddressAsync(string address, string benchmark = "Public_AR_Current", string format = "json")
    {
        if (string.IsNullOrEmpty(address))
        {
            throw new ArgumentException("Address cannot be null or empty.", nameof(address));
        }

        try
        {
            var queryString = BuildLookupAddressQueryString(address, benchmark, format);
            var url = $"geocoder/locations/onelineaddress{queryString}";

            var response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                // Log the response status code and content for debugging purposes. Adjust as per your logging mechanism.
                // Example: _logger.LogError($"Failed to geocode address. Status: {response.StatusCode}. Content: {await response.Content.ReadAsStringAsync()}");
                return null;
            }

            var stringContent = await response.Content.ReadAsStringAsync();
            return stringContent.DeserializeCaseInsensitive<GeocodingResponseDto>();
        }
        catch (HttpRequestException ex)
        {
            // Handle exceptions related to the HTTP request (e.g., network issues, timeouts).
            // Log the exception. Adjust as per your logging mechanism.
            // Example: _logger.LogError(ex, "Error occurred while trying to geocode address.");
            return null;
        }
        catch (Exception ex)
        {
            // Handle other unexpected issues.
            // Log the exception. Adjust as per your logging mechanism.
            // Example: _logger.LogError(ex, "An unexpected error occurred.");
            return null;
        }
    }

    private static string BuildLookupAddressQueryString(string address, string benchmark = "Public_AR_Current", string format = "json")
    {
        var geocodingParams = new List<KeyValuePair<string, string>>
        {
            new("address", Uri.EscapeDataString(address)),
            new("benchmark", benchmark),
            new("format", format)
        };

        var queryString = QueryString.Create(geocodingParams!);
        return queryString.Value!;
    }
}