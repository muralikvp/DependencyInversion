using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.BLL
{
    public interface IDummyWeatherRepository
    {
        IEnumerable<WeatherForecast> Get(string cityName, int numberOdDays);
    }
}