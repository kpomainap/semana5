using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
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

        [HttpGet("DevolverAlumno")]
        public string DevolverAlumno()
        {
            string mensaje = string.Empty;
            Alumno Alumno1 = new Alumno();
            Alumno Alumno2 = new Alumno("Juan","Perez","60778562");
            return Alumno1.DevolverNombreCompleto();
        }

        [HttpGet("DevolverAlumno")]
        public string DevolverSuma()
        {
            string mensaje = string.Empty;
            Alumno Alumno1 = new Alumno();
            Alumno Alumno2 = new Alumno("Juan", "Perez", "60778562");
            return Alumno1.DevolverNombreCompleto();
        }

        [HttpGet("DevolverDocumento")]
        public string DevolverDocumento()
        {
            string mensaje = string.Empty;
            Alumno Alumno1 = new Alumno();
            Alumno Alumno2 = new Alumno("Juan", "Perez", "60778562");
            return Alumno2.DevolverDocumento();
        }

        [HttpGet("DevoloverEdad")]
        public int DevoloverEdad()
        {
            string mensaje = string.Empty;
            Alumno Alumno3 = new Alumno("Katy", "Paredes", "60778562", new DateTime(2000, 5, 25));
            return Alumno3.DevoloverEdad();
        }
    }
}
