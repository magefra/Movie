using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRank.Infrastructure.Comunications
{
    public class MovieRankResponse
    {
        public string MovieName { get; set; }

        public double OverallRanking { get; set; }
    }
}
