using Microsoft.AspNetCore.Mvc;
using webAPI.Models;

namespace webAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
       
        [HttpGet]
        public IEnumerable<Author> Get()
        {
           // create an instance of db context and retrieve data from it
           using(var context = new BookStoresDbContext())
            {
                return context.Authors.ToList();
            }
        }

        [HttpGet("{id:int}", Name = "GetAuthorsById")]
        public IEnumerable<Author> GetAuthorsById(int id)
        {
            using(var context = new BookStoresDbContext())
            {
                return context.Authors.Where(u=>u.AuthorId == id).ToList();
            }
        }

        // post
        [HttpPost]
        public IEnumerable<Author> CreateAuthor(Author author)
        {
            using(var context = new BookStoresDbContext())
            {
                 context.Authors.Add(author);
                 context.SaveChanges();
                //return CreatedAtRoute(context,);
                return (IEnumerable<Author>)Ok(context);
            }
        }
    }
}