namespace Weather.Forecast.API.DTOs.Gateways.Weather;

public record MeasurementDto
{
    public string? UnitCode { get; set; }
    public double? Value { get; set; }
}