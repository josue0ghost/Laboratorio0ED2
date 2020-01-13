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
        private static readonly Movie[] movies = new[]
        {
            new Movie {Id = 1, Director = "Me", Name = "Memento", Year = 2013 },
            new Movie{Id = 2, Director = "Cristopher Nolan", Name = "Batman", Year = 2010},
            new Movie{Id = 3, Director = "D1", Name = "N1", Year = 2000},
            new Movie{Id = 4, Director = "D2", Name = "N2", Year = 2001},
            new Movie{Id = 5, Director = "D3", Name = "N3", Year = 2002},
            new Movie{Id = 6, Director = "D4", Name = "N4", Year = 2003},
            new Movie{Id = 7, Director = "D5", Name = "N5", Year = 2004},
            new Movie{Id = 8, Director = "D6", Name = "N6", Year = 2005},
            new Movie{Id = 9, Director = "D7", Name = "N7", Year = 2006},
            new Movie{Id = 10, Director = "DA1", Name = "NA1", Year = 2007}
        };

        // GET: api/Movie
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] { "value", "value1" };
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
