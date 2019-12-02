using AutoMapper;
using MovieRank.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRank.Services.Mapper
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<MovieDb, Infrastructure.Comunications.MovieResponse>();
            CreateMap<Infrastructure.Comunications.MovieResponse,MovieDb>();
        }
    }
}
