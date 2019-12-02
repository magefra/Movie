using MovieRank.Core.Models;
using MovieRank.Infrastructure.Comunications;
using System.Collections.Generic;

namespace MovieRank.Services.Mapper
{
    public interface IMapper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        IEnumerable<MovieResponse> ToMovieContract(IEnumerable<MovieDb> items);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        MovieResponse ToMovieContract(MovieDb movie);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="movieRankRequest"></param>
        /// <returns></returns>
        MovieDb ToMovieDbModel(int userId, MovieRankRequest movieRankRequest);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="movieDbRequest"></param>
        /// <param name="movieUpdateRequest"></param>
        /// <returns></returns>
        MovieDb ToMovieDbModel(int userId, MovieDb movieDbRequest, MovieUpdateRequest movieUpdateRequest);
    }
}