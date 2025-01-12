using Microsoft.AspNetCore.Mvc;

namespace Modules.Customers.Presntation.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerSetupController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<CustomerSetupController> _logger;

    public CustomerSetupController(ILogger<CustomerSetupController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCustomerSetupWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}

