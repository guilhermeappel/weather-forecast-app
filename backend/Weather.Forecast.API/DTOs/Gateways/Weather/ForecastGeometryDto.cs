namespace Weather.Forecast.API.DTOs.Gateways.Weather;

public class ForecastGeometryDto
{
    public string? Type { get; set; }
    public List<List<List<double>>>? Coordinates { get; set; }
}