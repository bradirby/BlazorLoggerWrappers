using BlazorLoggerWrappers.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorLoggerWrappers.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IMessageLogger _msgLogger;

        public WeatherForecastController(IMessageLogger logger)
        {
            _msgLogger = logger;
            _msgLogger.SetLoggerType<WeatherForecastController>();
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            _msgLogger.Debug("Getting the weather forecast");
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
