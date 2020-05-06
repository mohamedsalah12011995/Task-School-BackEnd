using AutoMapper;
using School.Data;
using School.Data.Entities;
using School.Domain;
using School.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.Service
{
    public class ClassesService : BaseService, IClassesService

    {
        public ClassesService(IMapper _mapper, SchoolContext schoolContext)
        {

            mapper = _mapper;
            dbcontext = schoolContext;
        }

        public ICollection<ClassesModel> GetAll()
        {
            var ClassesList = dbcontext.Schools.ToList();
            var SchoolMapped = mapper.Map<List<ClassesModel>>(ClassesList);

            if (SchoolMapped != null)
            {
                return SchoolMapped;
            }
            else
            {
                return null;
            }
        }

        public ClassesModel GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public ClassesModel InsertOrUpdate(ClassesModel model)
        {
            if (model.Id > 0)
            {
                var _class = dbcontext.Classes.Find(model.Id);
                if (_class != null)
                {
                    var mappedClasses = mapper.Map<ClassesModel, Classes>(model,_class );

                    dbcontext.Classes.Update(mappedClasses);
                    dbcontext.SaveChanges();
                    return model;
                }
                else { return null; }

            }
            else
            {
                var mappedClasses = mapper.Map<Classes>(model);

                dbcontext.Classes.Add(mappedClasses);
                dbcontext.SaveChanges();
                return model;
            }
        }

    }
}
