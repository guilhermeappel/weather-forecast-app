namespace Weather.Forecast.API.DTOs.Gateways.Geocodings;

public record GeocodingResponseDto
{
    public ResultDto? Result { get; set; }
}