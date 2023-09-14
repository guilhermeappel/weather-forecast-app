namespace Weather.Forecast.API.DTOs.Gateways.Geocodings;

public record ResultDto
{
    public InputDto? Input { get; set; }
    public List<AddressMatchDto>? AddressMatches { get; set; }
}