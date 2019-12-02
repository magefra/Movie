using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRank.Core.Models
{
    [DynamoDBTable("MovieRank")]
    public class MovieDb
    {
        [DynamoDBHashKey]
        public int UserId { get; set; }

        [DynamoDBGlobalSecondaryIndexHashKey]
        public string MovieName { get; set; }

        [DynamoDBProperty]
        public string Description { get; set; }

        [DynamoDBProperty]
        public List<string> Actors { get; set; }

        [DynamoDBProperty]
        public int Ranking { get; set; }

        [DynamoDBProperty]
        public string RankedDateTime { get; set; }

    }
}
