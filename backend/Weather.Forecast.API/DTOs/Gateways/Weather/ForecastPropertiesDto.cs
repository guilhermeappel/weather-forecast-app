namespace Weather.Forecast.API.DTOs.Gateways.Weather;

public record ForecastPropertiesDto
{
    public DateTime Updated { get; set; }
    public string? Units { get; set; }
    public string? ForecastGenerator { get; set; }
    public DateTime GeneratedAt { get; set; }
    public DateTime UpdateTime { get; set; }
    public string? ValidTimes { get; set; }
    public MeasurementDto? Elevation { get; set; }
    public List<PeriodDto>? Periods { get; set; }
}