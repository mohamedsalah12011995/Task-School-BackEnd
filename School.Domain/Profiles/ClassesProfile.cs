using AutoMapper;
using School.Data;
using School.Data.Entities;
using School.Domain.Model;

namespace School.Domain.Profiles
{
    public class ClassesProfile : Profile
    {
        public ClassesProfile()
        {

            CreateMap<ClassesModel, Classes>();
            CreateMap<Classes, ClassesModel>();
        }
    }
}