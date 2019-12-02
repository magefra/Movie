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
    }
}