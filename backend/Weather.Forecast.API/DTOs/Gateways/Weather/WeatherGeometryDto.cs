namespace Weather.Forecast.API.DTOs.Gateways.Weather;

public record WeatherGeometryDto
{
    public string? Type { get; set; }
    public List<double>? Coordinates { get; set; }
}