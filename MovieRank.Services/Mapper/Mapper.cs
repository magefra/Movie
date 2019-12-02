using MovieRank.Core.Models;
using MovieRank.Infrastructure.Comunications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieRank.Services.Mapper
{
    public class Mapper : IMapper
    {
        public IEnumerable<MovieResponse> ToMovieContract(IEnumerable<MovieDb> items)
        {
            return items.Select(ToMovieContract);
        }

        public MovieResponse ToMovieContract(MovieDb movie)
        {
            return new MovieResponse
            {
                MovieName = movie.MovieName,
                Description = movie.Description,
                Actors = movie.Actors,
                Ranking = movie.Ranking,
                RankedDateTime = movie.RankedDateTime
            };
        }
    }
}
