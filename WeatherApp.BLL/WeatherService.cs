
namespace WeatherApp.BLL;

public interface IWeatherService
{
    IEnumerable<WeatherForecast> Get(string cityName, int numberOfDays);
}

public class WeatherService : IWeatherService
{
    private readonly IDummyWeatherRepository repository;

    public WeatherService(IDummyWeatherRepository repository)
    {
        this.repository = repository;
    }
    public IEnumerable<WeatherForecast> Get(string cityName, int numberOfDays)
    {
        return repository.Get(cityName, numberOfDays);
    }

}
