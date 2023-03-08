using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.DAL
{
    public class WeatherForeCastDto
    {
    public DateOnly Date { get; set; }

    public int Temperature { get; set; }

    public string? Summary { get; set; }
    }
}