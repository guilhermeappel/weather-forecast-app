using System.Text.Json.Serialization;

namespace Weather.Forecast.API.DTOs.Gateways.Weather;

public record WeatherResponseDto
{
    [JsonPropertyName("@context")]
    public List<object>? Context { get; set; }

    public string? Id { get; set; }
    public string? Type { get; set; }
    public WeatherGeometryDto? Geometry { get; set; }
    public WeatherPropertiesDto? Properties { get; set; }
}