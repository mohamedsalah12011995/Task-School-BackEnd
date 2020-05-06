using School.Domain.Model;
using System;
using System.Collections.Generic;

namespace School.Service
{
    public interface IClassesService
    {
        ClassesModel GetById(int Id);
        ClassesModel InsertOrUpdate(ClassesModel value);
        ICollection<ClassesModel> GetAll();

    }
}
