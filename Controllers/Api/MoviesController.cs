using Contoso.Fabrikam.Web.Models;
using Contoso.Fabrikam.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Contoso.Fabrikam.Web.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieService _movieService;

        public MoviesController(MovieService movieService)
        {
            _movieService = movieService;
        }
        
        [HttpGet]
        public ActionResult<List<Movie>> Get() =>
            _movieService.Get();

        [HttpGet("{id:length(24)}", Name = "GetMovie")]
        public ActionResult<Movie> Get(string id)
        {
            var movie = _movieService.Get(id);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }
    }
}