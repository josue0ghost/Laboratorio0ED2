using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using Newtonsoft.Json;

namespace clienteHTTP
{
    class Program
    {
        public static readonly HttpClient client = new HttpClient();
        public class Movie
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Director { get; set; }
            public int Year { get; set; }
        }
        static void Main(string[] args)
        {
            //CrearPelicula();
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task<IEnumerable<Movie>> getPeliculas(string path) {            
            var webResponse =  await client.GetAsync(path);

            if (!webResponse.IsSuccessStatusCode)
                return null;

            return await webResponse.Content.ReadAsAsync<List<Movie>>();
        }

        static async Task RunAsync() {            
            //Console.WriteLine("Hello World!");            
            client.BaseAddress = new Uri("https://localhost:44318/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var peliculas = await getPeliculas("https://localhost:44318/movie");

            Console.WriteLine("Id:" + "\t" + "Nombre:" + "\t" + "Director:" + "\t" + "Año:");

            foreach (var item in peliculas)
            {                
                Console.WriteLine(item.Id + "\t" + item.Name + "\t" + item.Director +"\t" + item.Year);
            }

            
            Console.ReadLine();
        }

        static void CrearPelicula() {
            Movie ingresar = new Movie { Id = 11, Name = "UP", Director = "Eduardo", Year = 2010 };
            HttpResponseMessage responsePost = client.PostAsJsonAsync("https://localhost:44318/movie", ingresar).Result;
        }
    }
}
