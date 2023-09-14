using Weather.Forecast.API.Gateways.Implementations;
using Weather.Forecast.API.Gateways.Interfaces;

namespace Weather.Forecast.API.Configurations;

public static class GatewaysConfiguration
{
    public static IServiceCollection AddGatewaysConfiguration(this IServiceCollection services)
    {
        services.AddScoped<IGeocodingGateway, GeocodingGateway>();
        services.AddScoped<IWeatherGateway, WeatherGateway>();

        return services;
    }
}