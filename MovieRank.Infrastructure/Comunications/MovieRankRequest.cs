﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRank.Infrastructure.Comunications
{
    public class MovieRankRequest
    {

        public string MovieName { get; set; }
        public string Description { get; set; }
        public List<string> Actors { get; set; }
        public int Ranking { get; set; }
    }
}
