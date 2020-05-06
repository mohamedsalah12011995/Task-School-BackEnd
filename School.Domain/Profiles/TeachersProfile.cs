using AutoMapper;
using School.Data.Entities;
using School.Domain.Model;

namespace School.Domain.Profiles
{
    public class TeachersProfile:Profile
    {
        public TeachersProfile()
        {

            CreateMap<TeachersModel, Teachers>();
            CreateMap<Teachers, TeachersModel>();
        }
    }
}
