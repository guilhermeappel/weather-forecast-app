using System.Text.Json.Serialization;

namespace Weather.Forecast.API.DTOs.Gateways.Geocodings;

public record CoordinatesDto
{
    [JsonPropertyName("x")]
    public double Longitude { get; set; }

    [JsonPropertyName("y")]
    public double Latitude { get; set; }
}
