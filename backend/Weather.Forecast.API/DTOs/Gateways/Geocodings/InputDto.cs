namespace Weather.Forecast.API.DTOs.Gateways.Geocodings;

public record InputDto
{
    public AddressDto? Address { get; set; }
    public BenchmarkDto? Benchmark { get; set; }
}