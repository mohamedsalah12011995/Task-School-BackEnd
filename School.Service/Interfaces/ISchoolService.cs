using School.Domain.Model;
using System.Collections.Generic;

namespace School.Service
{
    public interface ISchoolService
    {
        SchoolModel GetById(int Id);
        SchoolModel InsertOrUpdate(SchoolModel value);
        ICollection<SchoolModel> GetAll();

    }
}
