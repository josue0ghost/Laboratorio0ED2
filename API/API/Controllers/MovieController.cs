using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using API.Models;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        

        // GET: api/Movie
        [HttpGet]
        public List<Movie> Get()
        {
            List<Movie> aux = new List<Movie>();
            int MoviesCount = Data.Instance.Movies.Count;
            if (MoviesCount > 0)
            {
                if (MoviesCount < 10)
                {
                    for (int i = 0; i < MoviesCount; i++)
                    {
                        aux.Add(Data.Instance.Movies.Pop());
                    }

                    for (int i = MoviesCount-1; i >= 0; i--)
                    {
                        Data.Instance.Movies.Push(aux[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < 10; i++)
                    {
                        aux.Add(Data.Instance.Movies.Pop());
                    }

                    for (int i = 9; i >= 0; i--)
                    {
                        Data.Instance.Movies.Push(aux[i]);
                    }
                }                
            }
            return aux;
        }

        // GET: api/Movie/5
        [HttpGet("{id}", Name = "Get")]
        public Movie Get(int id)
        {
            if (id <= Data.Instance.Movies.Count())
                return Data.Instance.Movies.ElementAt(id);

            return null;
        }

        private readonly ILogger<MovieController> _logger;

        public MovieController(ILogger<MovieController> logger)
        {
            _logger = logger;
        }

        // POST: api/Movie
        [HttpPost]
        public Movie Post([FromBody] Movie value)
        {
            if (value.Id == 0)            
                value.Id = Data.Instance.Movies.Count() + 1;
            
            Data.Instance.Movies.Push(value);
            return Data.Instance.Movies.Peek();
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
