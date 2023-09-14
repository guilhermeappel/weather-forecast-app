namespace Weather.Forecast.API.DTOs.Gateways.Geocodings;

public record AddressMatchDto
{
    public TigerLineDto? TigerLine { get; set; }
    public CoordinatesDto? Coordinates { get; set; }
    public AddressComponentsDto? AddressComponents { get; set; }
    public string? MatchedAddress { get; set; }
}