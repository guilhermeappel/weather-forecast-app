namespace Weather.Forecast.API.DTOs.Gateways.Geocodings;

public record BenchmarkDto
{
    public bool IsDefault { get; set; }
    public string? BenchmarkDescription { get; set; }
    public string? Id { get; set; }
    public string? BenchmarkName { get; set; }
}