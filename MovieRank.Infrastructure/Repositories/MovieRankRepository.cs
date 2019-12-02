using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using MovieRank.Core.Models;
using MovieRank.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieRank.Infrastructure.Repositories
{
    public class MovieRankRepository : IMovieRankRepository
    {

      

        /// <summary>
        /// 
        /// </summary>
        private readonly DynamoDBContext _context;

        public MovieRankRepository(IAmazonDynamoDB dynamoDbClient)
        {
         
                
            _context = new DynamoDBContext(dynamoDbClient);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<MovieDb>> GetAllItems()
        {

            var response = await _context.ScanAsync<MovieDb>(new List<ScanCondition>()).GetRemainingAsync();

            return response;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="movieName"></param>
        /// <returns></returns>
        public async Task<MovieDb> GetMovie(int userId, string movieName)
        {
            return await _context.LoadAsync<MovieDb>(userId, movieName);

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="movieName"></param>
        /// <returns></returns>
        public async Task<IEnumerable<MovieDb>> GetUserRankedMoviesByMovieTitle(int userId, string movieName)
        {
            var config = new DynamoDBOperationConfig()
            {
                QueryFilter = new List<ScanCondition>
                {
                    new ScanCondition("MovieName", ScanOperator.BeginsWith, movieName)
                }
            };

            return await _context.QueryAsync<MovieDb>(userId, config).GetRemainingAsync();

        }

    }
}
