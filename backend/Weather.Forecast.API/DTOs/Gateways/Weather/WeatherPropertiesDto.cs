using System.Text.Json.Serialization;

namespace Weather.Forecast.API.DTOs.Gateways.Weather;

public record WeatherPropertiesDto
{
    [JsonPropertyName("@id")]
    public string? Id { get; set; }

    [JsonPropertyName("@type")]
    public string? Type { get; set; }

    public string? Cwa { get; set; }
    public string? ForecastOffice { get; set; }
    public string? GridId { get; set; }
    public int GridX { get; set; }
    public int GridY { get; set; }
    public string? Forecast { get; set; }
    public string? ForecastHourly { get; set; }
    public string? ForecastGridData { get; set; }
    public string? ObservationStations { get; set; }
    public RelativeLocationDto? RelativeLocation { get; set; }
    public string? ForecastZone { get; set; }
    public string? County { get; set; }
    public string? FireWeatherZone { get; set; }
    public string? TimeZone { get; set; }
    public string? RadarStation { get; set; }
    public List<PeriodDto>? Periods { get; set; }
}