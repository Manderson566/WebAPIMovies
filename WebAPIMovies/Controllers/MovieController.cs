
using System.Data.Entity;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPIMovies.Models;

namespace WebAPIMovies.Controllers
{

    public class MovieController : ApiController
    {
        Context db = new Context();

        [ResponseType(typeof(Movie))]
        public IHttpActionResult Get()
        {
            DbSet<Movie> results = db.Movies;
            return Ok(results);
        }

        public IHttpActionResult Get(int id)
        {
            Movie result = db.Movies.Find(id);
            return Ok(result);
        }

        public IHttpActionResult Post (Movie movie)
        {
            db.Movies.Add(movie);
            db.SaveChanges();
            return Created("Get", movie);
        }

        public IHttpActionResult Put(int id, Movie movie)
        {
            movie.Id = id;
            db.Entry(movie).State = EntityState.Modified;

            db.SaveChanges();
            return Ok();
        }

        public IHttpActionResult Delete(int id )
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }
            

    }
}
