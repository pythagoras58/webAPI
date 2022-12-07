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
                Author author1 = new Author();
                author1.LastName = author.LastName;
                author1.FirstName = author.FirstName;
                author1.Address = author.Address;
                author1.EmailAddress = author.EmailAddress;
                author1.Phone= author.Phone;
                author1.City = author.City;
                //author1.State= author.State;

                 //author.AuthorId = context.Authors.OrderByDescending(x=>x.AuthorId).FirstOrDefault().AuthorId+1;

                 context.Authors.Add(author1);
                 context.SaveChanges();
                //return CreatedAtRoute(context,);
                return context.Authors.Where(u=>u.FirstName == author1.FirstName).ToList();
            }
        }

        [HttpPatch]
        public IEnumerable<Author> updateAuthor(Author author)
        {
            return null;
        }
    }
}