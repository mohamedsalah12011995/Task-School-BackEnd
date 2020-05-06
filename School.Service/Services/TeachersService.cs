using AutoMapper;
using School.Data;
using School.Data.Entities;
using School.Domain;
using School.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.Service.Services
{

    public class TeachersService : BaseService, ITeachersService

    {
        public TeachersService(IMapper _mapper, SchoolContext schoolContext)
        {

            mapper = _mapper;
            dbcontext = schoolContext;
        }

        public bool DeleteTeacher(int Id)
        {
            var find = dbcontext.Teachers.Find(Id);
            if (find !=null)
            {
                dbcontext.Teachers.Remove(find);
                dbcontext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public ICollection<TeachersModel> GetAll()
        {
            var TeacherslList = dbcontext.Teachers.ToList();
            var MappedTeachers = mapper.Map<List<TeachersModel>>(TeacherslList);

            if (MappedTeachers != null)
            {
                return MappedTeachers;
            }
            else
            {
                return null;
            }
        }

        public TeachersModel GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public TeachersModel InsertOrUpdate(TeachersModel model)
        {
            if (model.Id > 0)
            {
                var find = dbcontext.Teachers.Find(model.Id);
                if (find != null)
                {
                    var mappedTeachers = mapper.Map<TeachersModel, Teachers>(model, find);

                    dbcontext.Teachers.Update(mappedTeachers);
                    dbcontext.SaveChanges();
                    return model;
                }
                else { return null; }

            }
            else
            {
                var mappedTeachers = mapper.Map<Teachers>(model);
                dbcontext.Teachers.Add(mappedTeachers);
                dbcontext.SaveChanges();
                model.Id = mappedTeachers.Id;
                return model;
            }
        }
    }
}
