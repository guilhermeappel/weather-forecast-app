namespace Weather.Forecast.API.DTOs.Gateways.Weather;

public record RelativeLocationDto
{
    public string? Type { get; set; }
    public WeatherGeometryDto? Geometry { get; set; }
    public RelativeLocationPropertiesDto? Properties { get; set; }
}