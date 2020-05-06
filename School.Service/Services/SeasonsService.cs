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
    public class SeasonsService : BaseService, ISeasonslService
    {

        public SeasonsService(IMapper _mapper, SchoolContext _dbContext)
        {

            mapper = _mapper;
            dbcontext = _dbContext;
        }

        public ICollection<SeasonsModel> GetAll()
        {
            var SeasonsList = dbcontext.Seasons.ToList();
            var SeasonsMapper = mapper.Map<List<SeasonsModel>>(SeasonsList);

            if (SeasonsMapper != null)
            {
                return SeasonsMapper;
            }
            else
            {
                return null;
            }
        }

        public SeasonsModel GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public SeasonsModel InsertOrUpdate(SeasonsModel model)
        {
            if (model.Id > 0)
            {
                var find = dbcontext.Seasons.Find(model.Id);
                if (find != null)
                {
                    var mappedSeasons = mapper.Map<SeasonsModel, Seasons>(model, find);

                    dbcontext.Seasons.Update(mappedSeasons);
                    dbcontext.SaveChanges();
                    return model;
                }
                else { return null; }

            }
            else
            {
                var mappedApplication = mapper.Map<Seasons>(model);
                dbcontext.Seasons.Add(mappedApplication);
                dbcontext.SaveChanges();
                return model;
            }
        }
    }
}
