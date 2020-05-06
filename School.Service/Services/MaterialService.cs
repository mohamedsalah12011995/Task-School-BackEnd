using School.Data;
using System;
using System.Collections.Generic;
using System.Text;
using School.Domain;
using AutoMapper;
using School.Domain.Model;
using System.Linq;
using School.Data.Entities;

namespace School.Service
{
    public class MaterialService : BaseService, IMaterialService

    {
        public MaterialService(IMapper _mapper, SchoolContext schoolContext)
        {

            mapper = _mapper;
            dbcontext = schoolContext;
        }

        public ICollection<MaterialModel> GetAll()
        {
            var MaterialList = dbcontext.Materials.ToList();
            var MappedMaterial = mapper.Map<List<MaterialModel>>(MaterialList);

            if (MappedMaterial != null)
            {
                return MappedMaterial;
            }
            else
            {
                return null;
            }
        }

        public MaterialModel GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public MaterialModel InsertOrUpdate(MaterialModel model)
        {
            if (model.Id > 0)
            {
                var find = dbcontext.Materials.Find(model.Id);
                if (find != null)
                {
                    var mappedMaterial = mapper.Map<MaterialModel, Material>(model, find);

                    dbcontext.Materials.Update(mappedMaterial);
                    dbcontext.SaveChanges();
                    return model;
                }
                else { return null; }

            }
            else
            {
                var mappedMaterial = mapper.Map<Material>(model);
                dbcontext.Materials.Add(mappedMaterial);
                dbcontext.SaveChanges();
                return model;
            }
        }
    }
}
