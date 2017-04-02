using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;//Manaually typed
using Vidly.ViewModels;//Manaually typed


namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
           var movie = new Movie() { Name = "Shrek!" };
            //ViewResult.ViewData.Model
            var customers = new List<Customer>
            {
                new Customer {Name ="Customer 1" },
                new Customer {Name ="Customer 2" }
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers                
            };
            return View(viewModel);
            //return View(movie);
            // return Content("Hello Bhavana!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("index", "home", new { page = 1, sortby = "Name" });
        }
        /* public ActionResult Edit(int Id)
         {
             return Content("id=" +Id);
         }
         //movies
         public ActionResult Index(int? pageIndex, string sortby)
         {
             if (!pageIndex.HasValue)
                 pageIndex = 1;
             if (string.IsNullOrWhiteSpace(sortby))
                 sortby = "Name";
             return Content(string.Format("pageIndex={0} &sortBy={1}", pageIndex, sortby));
         }*/

       /* [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year +"/"+month);
        }*/
    }
}