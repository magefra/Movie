using MovieRank.Infrastructure.Comunications;
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
    }
}
