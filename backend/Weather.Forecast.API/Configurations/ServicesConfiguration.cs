using Weather.Forecast.API.Services.Implementations;
using Weather.Forecast.API.Services.Interfaces;

namespace Weather.Forecast.API.Configurations;

public static class ServicesConfiguration
{
    public static IServiceCollection AddServicesConfiguration(this IServiceCollection services)
    {
        services.AddScoped<IWeatherForecastService, WeatherForecastService>();

        return services;
    }
}