using System.Text.Json.Serialization;

namespace Weather.Forecast.API.DTOs.Gateways.Weather;

public record ForecastResponseDto
{
    [JsonPropertyName("@context")]
    public List<object>? Context { get; set; }
    public string? Type { get; set; }
    public ForecastGeometryDto? Geometry { get; set; }
    public ForecastPropertiesDto? Properties { get; set; }
}