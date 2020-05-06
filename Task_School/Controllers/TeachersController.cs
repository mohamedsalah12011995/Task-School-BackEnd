using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Domain.Model;
using School.Service;

namespace ESAResturant.NEW.web.Controllers
{
    [Route("api/Teachers")]
    public class TeachersController : Controller
    {
        private ITeachersService TeachersService;

        public TeachersController(ITeachersService _TeachersService)
        {
            TeachersService = _TeachersService;
        }
        // GET: api/Teachers
        [HttpGet]
        [Route("GetTeacherss")]
        public IEnumerable<TeachersModel> GetTeachers()
        {
            return TeachersService.GetAll();
        }


        // POST: api/InsertOrUpdateTeachers
        [HttpPost]
        [Route("InsertOrUpdateTeachers")]
        public void Post([FromBody] TeachersModel TeachersModel)
        {
            TeachersService.InsertOrUpdate(TeachersModel);
        }



        // GET: api/Teachers/5
        //[HttpGet]
        //[Route("GetTeachersbyId")]
        //public TeachersModel GetTeachersByid(int id)
        //{
        //    return TeachersService.GetTeachersByid(id);
        //}


        [HttpDelete]
        [Route("DeleteTeacher")]
        public void Delete(int id)
        {
            TeachersService.DeleteTeacher(id);
        }

    }
}
