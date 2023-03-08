using Microsoft.AspNetCore.Mvc;
using WeatherApp.BLL;

namespace ReactEx.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
   

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherService service;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,IWeatherService service)
    {
        _logger = logger;
        this.service = service;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get(string cityName= "Brisbane",int numberOfDays =3) 
    {
        return service.Get(cityName,numberOfDays);
    }
}
