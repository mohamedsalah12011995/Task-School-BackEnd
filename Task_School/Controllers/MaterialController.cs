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
    [Route("api/Material")]
    public class MaterialController : Controller
    {
        private IMaterialService MaterialService;

        public MaterialController(IMaterialService _MaterialService)
        {
            MaterialService = _MaterialService;
        }
        // GET: api/Material
        [HttpGet]
        [Route("GetMaterials")]
        public IEnumerable<MaterialModel> GetMaterial()
        {
            return MaterialService.GetAll();
        }




        // POST: api/InsertOrUpdateMaterial
        [HttpPost]
        [Route("InsertOrUpdateMaterial")]
        public void Post([FromBody] MaterialModel MaterialModel)
        {
            MaterialService.InsertOrUpdate(MaterialModel);
        }


        // GET: api/Material/5
        //[HttpGet]
        //[Route("GetMaterialbyId")]
        //public MaterialModel GetMaterialByid(int id)
        //{
        //    return MaterialService.GetMaterialByid(id);
        //}

        //[HttpDelete]
        //[Route("DeleteMaterial")]
        //public void Delete(int id)
        //{
        //    MaterialService.DeleteMaterial(id);
        //}

    }
}
