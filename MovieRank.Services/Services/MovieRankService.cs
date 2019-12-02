﻿
using MovieRank.Core.Models;
using MovieRank.Core.Repositories;
using MovieRank.Infrastructure.Comunications;
using MovieRank.Services.Mapper;
using MovieRank.Services.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieRank.Services
{
    public class MovieRankService : IMovieRankService
    {

        /// <summary>
        /// 
        /// </summary>
        private readonly IMovieRankRepository _movieRankRepository;

        /// <summary>
        /// 
        /// </summary>
        private readonly IMapper _mapper;



        public MovieRankService(IMovieRankRepository movieRankRepository, IMapper mapper)
        {
            _movieRankRepository = movieRankRepository;
            _mapper = mapper;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<MovieResponse>> GetAllItemsFromDatabase()
        {
            var response = await _movieRankRepository.GetAllItems();

            return _mapper.ToMovieContract(response);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="movieName"></param>
        /// <returns></returns>
        public async Task<MovieResponse> GetMovie(int userId, string movieName)
        {
            var response = await _movieRankRepository.GetMovie(userId, movieName);

            return _mapper.ToMovieContract(response);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="movieName"></param>
        /// <returns></returns>
        public async Task<IEnumerable<MovieResponse>> GetUserRankedMoviesByMovieTitle(int userId, string movieName)
        {
            var response = await _movieRankRepository.GetUserRankedMoviesByMovieTitle(userId, movieName);


            return _mapper.ToMovieContract(response);
        }

    }
}
