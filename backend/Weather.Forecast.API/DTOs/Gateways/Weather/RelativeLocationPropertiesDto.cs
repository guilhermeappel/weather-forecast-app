namespace Weather.Forecast.API.DTOs.Gateways.Weather;

public record RelativeLocationPropertiesDto
{
    public string? City { get; set; }
    public string? State { get; set; }
    public MeasurementDto? Distance { get; set; }
    public MeasurementDto? Bearing { get; set; }
}