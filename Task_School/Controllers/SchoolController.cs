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
    [Route("api/School")]
    public class SchoolController : Controller
    {
        private ISchoolService SchoolService;

        public SchoolController(ISchoolService _SchoolService)
        {
            SchoolService = _SchoolService;
        }
        //GET: api/School
       [HttpGet]
       [Route("GetSchools")]
        public IEnumerable<SchoolModel> GetSchool()
        {
            return SchoolService.GetAll();
        }

        // GET: api/School/5
        //[HttpGet]
        //[Route("GetSchoolbyId")]
        //public SchoolModel GetSchoolByid(int id)
        //{
        //    return SchoolService.GetSchoolByid(id);
        //}


        // POST: api/InsertOrUpdateSchool
        //[HttpPost]
        //[Route("InsertOrUpdateSchool")]
        //public void Post([FromBody] SchoolModel SchoolModel)
        //{
        //    SchoolService.InsertOrUpdate(SchoolModel);
        //}


        //[HttpDelete]
        //[Route("DeleteSchool")]
        //public void Delete(int id)
        //{
        //    SchoolService.DeleteSchool(id);
        //}

    }
}
