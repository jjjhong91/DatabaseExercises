using System.Threading.Tasks;
using DatabaseExercises.Controllers.Queries;
using DatabaseExercises.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseExercises.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly BloggingContext _context;
        private readonly BlogQueries _queries;

        public BlogController(BloggingContext context, BlogQueries queries)
        {
            _context = context;
            _queries = queries;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _queries.GetBlogsAsync();

            return Ok(result);
        }

        [HttpGet("seed")]
        public IActionResult Seed()
        {
            var blog = new Blog
            {
                Url = "http://localhost:5000/swagger"
            };
            _context.Add(blog);
            _context.SaveChanges();
            return Ok();
        }
    }
}