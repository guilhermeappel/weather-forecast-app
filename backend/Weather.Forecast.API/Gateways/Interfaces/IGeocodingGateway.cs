using Weather.Forecast.API.DTOs.Gateways.Geocodings;

namespace Weather.Forecast.API.Gateways.Interfaces;

public interface IGeocodingGateway
{
    Task<GeocodingResponseDto?> GeocodeSingleLineAddressAsync(string address, string benchmark = "Public_AR_Current", string format = "json");
}