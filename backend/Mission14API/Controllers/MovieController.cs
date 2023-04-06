using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mission14API.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mission14API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class MovieController : Controller
    {
        //Variable of type FoodDbContext that we can use
        private MovieDbContext context;

        public MovieController(MovieDbContext temp)
        {
            //Instantiate the instance
            context = temp;
        }
        public IEnumerable<Movie> Get()
        {
            //Use IEnumarable to query the data from the database
            var x = context.Movies
                .Where(m => m.edited == "Yes")
                .OrderBy(m => m.title)
                .ToArray();

            return (x);
        }
    }
}

