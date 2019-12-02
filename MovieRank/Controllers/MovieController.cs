using Microsoft.AspNetCore.Mvc;
using MovieRank.Infrastructure.Comunications;
using MovieRank.Services;
using MovieRank.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRank.Controllers
{

    [Route("/api/movies")]
    public class MovieController : ControllerBase
    {

        private readonly IMovieRankService _movieRankService;



        public MovieController(IMovieRankService movieRankService)
        {
            _movieRankService = movieRankService;
        }



        [HttpGet]
        public async Task<IEnumerable<MovieResponse>> GetAllItemsFromDatabase()
        {
            var results = await _movieRankService.GetAllItemsFromDatabase();

            return results;
        }
    }
}
