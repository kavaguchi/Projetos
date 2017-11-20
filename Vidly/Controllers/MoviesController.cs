using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            return View(movie);
        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return View("year: " + year + " month: " + month);
        }

    }
}