using static Weather.Forecast.API.Constants.ConfigurationConstants;

namespace Weather.Forecast.API.Configurations;

public static class HttpClientsConfiguration
{
    public static IServiceCollection AddHttpClientConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpClient(HttpConfiguration.GEOCODING_API, c =>
        {
            c.BaseAddress = new Uri(configuration["Gateways:GeocodingApi:BaseUrl"]);
        });

        services.AddHttpClient(HttpConfiguration.WEATHER_API, c =>
        {
            c.BaseAddress = new Uri(configuration["Gateways:WeatherApi:BaseUrl"]);
            c.DefaultRequestHeaders.Add("User-Agent", configuration["Gateways:WeatherApi:UserAgent"]);
        });

        return services;
    }
}