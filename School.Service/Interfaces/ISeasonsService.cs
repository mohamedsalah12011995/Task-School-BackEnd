using School.Domain.Model;
using System.Collections.Generic;

namespace School.Service
{
    public interface ISeasonslService
    {
        ICollection<SeasonsModel> GetAll();
        SeasonsModel GetById(int Id);
        SeasonsModel InsertOrUpdate(SeasonsModel value);

    }
}
