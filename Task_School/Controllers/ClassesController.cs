using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Service;
using School.Domain.Model;

namespace ESAResturant.NEW.web.Controllers
{
    [Route("api/Classes")]
    public class ClassesController : Controller
    {
        private IClassesService ClassesService;

        public ClassesController(IClassesService _ClassesService)
        {
            ClassesService = _ClassesService;
        }
        // GET: api/Classes
        [HttpGet]
        [Route("GetClassess")]
        public IEnumerable<ClassesModel> GetClasses()
        {
            return ClassesService.GetAll();
        }


        // POST: api/InsertOrUpdateClasses
        [HttpPost]
        [Route("InsertOrUpdateClasses")]
        public void Post([FromBody] ClassesModel ClassesModel)
        {
            ClassesService.InsertOrUpdate(ClassesModel);
        }


        // GET: api/Classes/5
        //[HttpGet]
        //[Route("GetClassesbyId")]
        //public ClassesModel GetClassesByid(int id)
        //{
        //    return ClassesService.GetClassesByid(id);
        //}


        //[HttpDelete]
        //[Route("DeleteClasses")]
        //public void Delete(int id)
        //{
        //    ClassesService.DeleteClasses(id);
        //}

    }
}
