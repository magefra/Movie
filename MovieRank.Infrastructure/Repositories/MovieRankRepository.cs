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

        private DynamoDBOperationConfig _config;

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

    }
}
