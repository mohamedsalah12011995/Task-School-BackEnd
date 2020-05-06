using AutoMapper;
using School.Data;
using School.Data.Entities;
using School.Domain.Model;

namespace School.Domain.Profiles
{
    public class MaterialProfile : Profile
    {
        public MaterialProfile()
        {

            CreateMap<MaterialModel, Material>();
            CreateMap<Material, MaterialModel>();
        }
    }
}