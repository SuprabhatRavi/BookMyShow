using BookMyTicketServices.Modals;
using Microsoft.AspNetCore.Mvc;

namespace BookMyTicketServices.Controllers
{
    [ApiController]
    [Route("weatherapi/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        private PetaPoco.Database Dbo;



        public WeatherForecastController(ILogger<WeatherForecastController> logger, PetaPoco.Database dbo)
        {
            _logger = logger;
            Dbo = dbo;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("{id}")]
        public IEnumerable<UsersDTO> GetUsers(int id)
        {
            var UserList = Dbo.Query<UsersDTO>("Select * from Users");
            return UserList;
        }
    }
}