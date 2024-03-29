﻿using Microsoft.AspNetCore.Mvc;
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


        [HttpGet]
        [Route("{userId}/{movieName}")]
        public async Task<MovieResponse> GetMovie(int userId, string movieName)
        {
            var result = await _movieRankService.GetMovie(userId, movieName);

            return result;
        }


        [HttpGet]
        [Route("user/{userId}/rankedMovies/{movieName}")]
        public async Task<IEnumerable<MovieResponse>> GetUsersRankedMoviesByMovieTitle(
                                        int userId,
                                        string movieName)
        {

            var results = await _movieRankService.GetUserRankedMoviesByMovieTitle(userId, movieName);

            return results;
        
        
        }


        [HttpPost]
        [Route("{userId}")]
        public async Task<IActionResult> AddMovie(int userId,
                                                  [FromBody] MovieRankRequest movieRankRequest)
        {

            await _movieRankService.AddMovie(userId, movieRankRequest);

            return Ok();
        }


        [HttpPatch]
        [Route("{userId}")]
        public async Task<IActionResult> UdapteMovie(int userId, 
                                                     [FromBody] MovieUpdateRequest request)
        {
            await _movieRankService.UpdateMovie(userId, request);

            return Ok();
        }

        [HttpGet]
        [Route("{movieName}/ranking")]
        public async Task<MovieRankResponse> GetMoviesRanking(string movieName)
        {
            var result = await _movieRankService.GetMovieRank(movieName);

            return result;
        }
    }
}
