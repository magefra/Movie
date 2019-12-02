using MovieRank.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieRank.Core.Repositories
{
    public interface IMovieRankRepository
    {

        Task<IEnumerable<MovieDb>> GetAllItems();
    }
}
