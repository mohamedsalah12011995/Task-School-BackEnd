using AutoMapper;
using School.Data.Entities;
using School.Domain.Model;

namespace School.Domain.Profiles
{
    public class SeasonsProfile : Profile
    {
        public SeasonsProfile()
        {

            CreateMap<SeasonsModel, Seasons>();
            CreateMap<Seasons, SeasonsModel>();
        }
    }
}