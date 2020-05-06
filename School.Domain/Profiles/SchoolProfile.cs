using AutoMapper;
using School.Data.Entities;
using School.Domain.Model;

namespace School.Domain.Profiles
{
    public class SchoolProfile : Profile
    {
        public SchoolProfile()
        {

            CreateMap<SchoolModel, SchoolInfo>();
            CreateMap<SchoolInfo, SchoolModel>();
        }
    }
}