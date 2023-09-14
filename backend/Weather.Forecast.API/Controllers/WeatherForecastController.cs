using Microsoft.AspNetCore.Mvc;
using Weather.Forecast.API.Services.Interfaces;

namespace Weather.Forecast.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherForecastService _weatherForecastService;

    public WeatherForecastController(IWeatherForecastService weatherForecastService)
    {
        _weatherForecastService = weatherForecastService;
    }

    /// <summary>
    /// Fetches the weather data based on the provided address.
    /// </summary>
    /// <param name="address">The address for which the weather data needs to be fetched.</param>
    /// <returns>Weather data for the given address.</returns>
    /// <remarks>
    /// Example usage:
    /// 
    ///     GET /weatherforecast?address=4600 Silver Hill Rd, Washington, DC 20233
    ///     
    /// Remarks:
    /// 
    ///     The provided address is used to fetch the geographical coordinates which are then used to get the weather data.
    ///     If the address is invalid or weather data is not found, the API returns a not found response.
    /// </remarks>
    [HttpGet]
    public async Task<IActionResult> GetWeatherByAddress([FromQuery] string address)
    {
        var periodsDtos = await _weatherForecastService.GetWeatherForAddressAsync(address);
        if (periodsDtos == null)
        {
            return NotFound("Weather data not found for the given address.");
        }

        return Ok(periodsDtos);
    }
}
