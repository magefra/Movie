using MovieRank.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieRank.Core.Repositories
{
    public interface IMovieRankRepository
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<MovieDb>> GetAllItems();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="movieName"></param>
        /// <returns></returns>
        Task<MovieDb> GetMovie(int userId, string movieName);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="movieName"></param>
        /// <returns></returns>
        Task<IEnumerable<MovieDb>> GetUserRankedMoviesByMovieTitle(int userId, string movieName);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="movieDb"></param>
        /// <returns></returns>
        Task AddMovie(MovieDb movieDb);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task UpdateMovie(MovieDb request);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="movieName"></param>
        /// <returns></returns>
        Task<IEnumerable<MovieDb>> GetMovieRank(string movieName);
    }
}
