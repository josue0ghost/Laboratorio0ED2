using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        // GET: api/Movie
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return new Movie[] { new Movie { Director = "Me", Name = "Memento", Year = 2013 } };
        }

        // GET: api/Movie/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Movie
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Movie/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
