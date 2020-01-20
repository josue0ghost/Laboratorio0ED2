using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Controllers
{
	public class Data
	{
		private static Data instance = null;

		public static Data Instance
		{
			get
			{
				if (instance == null) instance = new Data();
				return instance;
			}
		}

        private static Movie[] movies = {
            new Movie { Id = 1, Director = "Me", Name = "Memento", Year = 2013 },
            new Movie { Id = 2, Director = "Cristopher Nolan", Name = "Batman", Year = 2010 },
            new Movie { Id = 3, Director = "D1", Name = "N1", Year = 2000 },
            new Movie { Id = 4, Director = "D2", Name = "N2", Year = 2001 },
            new Movie { Id = 5, Director = "D3", Name = "N3", Year = 2002 },
            new Movie { Id = 6, Director = "D4", Name = "N4", Year = 2003 },
            new Movie { Id = 7, Director = "D5", Name = "N5", Year = 2004 },
            new Movie { Id = 8, Director = "D6", Name = "N6", Year = 2005 },
            new Movie { Id = 9, Director = "D7", Name = "N7", Year = 2006 },
            new Movie { Id = 10, Director = "DA1", Name = "NA1", Year = 2007 },
            new Movie { Id = 11, Director = "DA2", Name = "NA2", Year = 2008 },
            new Movie { Id = 12, Director = "DA3", Name = "NA3", Year = 2009 },
            new Movie { Id = 13, Director = "DA4", Name = "NA4", Year = 2010 }
        };

        public Stack<Movie> Movies = new Stack<Movie>(movies);
    }
}
