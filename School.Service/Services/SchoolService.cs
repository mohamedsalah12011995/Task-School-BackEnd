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
    public class SchoolService :BaseService , ISchoolService
    {

        public SchoolService(IMapper _mapper, SchoolContext schoolContext)
        {

            mapper = _mapper;
            dbcontext = schoolContext;
        }

        public SchoolModel InsertOrUpdate(SchoolModel schoolModel)
        {
            if (schoolModel.Id > 0)
            {
                var find = dbcontext.Schools.Find(schoolModel.Id);
                if (find != null)
                {
                    var mappedSchool = mapper.Map<SchoolModel, SchoolInfo>(schoolModel, find);
                    dbcontext.Schools.Update(mappedSchool);
                    dbcontext.SaveChanges();
                    return schoolModel;
                }
                else { return null; }

            }
            else
            {
                var mappedApplication = mapper.Map<SchoolInfo>(schoolModel);
                dbcontext.Schools.Add(mappedApplication);
                dbcontext.SaveChanges();
                return schoolModel;
            }

        }

        public ICollection<SchoolModel> GetAll()
        {
            var SchoolList = dbcontext.Schools.ToList();
            var ListSchool = mapper.Map<List<SchoolModel>>(SchoolList);

            if (SchoolList !=null)
            {
                return ListSchool;
            }
            else
            {
                return null;
            }
        }

        public SchoolModel GetById(int Id)
        {
            var _School = dbcontext.Schools.Where(s => s.Id == Id).ToList();
            var school = mapper.Map<SchoolModel>(_School);

            if (school != null)
            {
                return school;
            }
            else
            {
                return null;
            }
        }

    }
}
