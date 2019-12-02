﻿using MovieRank.Infrastructure.Comunications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieRank.Services.Services
{
    public interface IMovieRankService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<MovieResponse>> GetAllItemsFromDatabase();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="movieName"></param>
        /// <returns></returns>
        Task<MovieResponse> GetMovie(int userId, string movieName);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="movieName"></param>
        /// <returns></returns>
        Task<IEnumerable<MovieResponse>> GetUserRankedMoviesByMovieTitle(int userId, string movieName);
    }
}
