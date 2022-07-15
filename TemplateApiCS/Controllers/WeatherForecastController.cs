using TemplateApiCS.Models;
using Microsoft.AspNetCore.Mvc;
using TemplateApiCS.Database;
using TemplateApiCS.Database.Models;

namespace TemplateApiCS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : BaseController
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public DatabaseContext DatabaseContext { get; set; }

        public WeatherForecastController(DatabaseContext DatabaseContext, ILogger<WeatherForecastController> Logger) : base(Logger)
        {
            this.DatabaseContext = DatabaseContext;
        }

        [HttpGet]
        public IEnumerable<Datum> Get(string locationId, DateTime start, DateTime end)
        {
            var data = DatabaseContext.Data.Where(data => data.LocationId == locationId && data.Dttm > start && data.Dttm < end);

            data = data.OrderByDescending(item => item.Dttm);

            return data;
        }

        [HttpPost]
        public async Task Post(Datum data) 
        {
            // That should save things into the database each time the sensor posts

            // this adds things into the ef core entity tracker
            await DatabaseContext.AddAsync(data);

            // this persists the changes into the database
            await DatabaseContext.SaveChangesAsync();
        }
    }
}