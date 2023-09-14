using System.Text.Json;

namespace Weather.Forecast.API.Extensions;

public static class JsonExtensions
{
    public static T? DeserializeCaseInsensitive<T>(this string json)
    {
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        return JsonSerializer.Deserialize<T>(json, options);
    }
}