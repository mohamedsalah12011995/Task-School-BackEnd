using School.Domain.Model;
using System.Collections.Generic;

namespace School.Service
{
    public interface ITeachersService
    {
        TeachersModel GetById(int Id);
        bool DeleteTeacher(int Id);
        TeachersModel InsertOrUpdate(TeachersModel value);
        ICollection<TeachersModel> GetAll();

    }
}
