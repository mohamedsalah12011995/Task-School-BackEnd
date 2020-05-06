using School.Domain.Model;
using System.Collections.Generic;

namespace School.Service
{
    public interface IMaterialService
    {
        MaterialModel GetById(int Id);
        MaterialModel InsertOrUpdate(MaterialModel value);
        ICollection<MaterialModel> GetAll();



    }
}
