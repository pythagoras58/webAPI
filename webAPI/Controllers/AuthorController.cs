using Microsoft.AspNetCore.Mvc;
using webAPI.Models;

namespace webAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
       
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Author> Get()
        {
           // create an instance of db context and retrieve data from it
           using(var context = new BookStoresDbContext())
            {
                return context.Authors.ToList();
            }
        }
    }
}