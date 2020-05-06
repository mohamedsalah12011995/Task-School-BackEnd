using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using School.Domain.Model;
using School.Service;

namespace ESAResturant.NEW.web.Controllers
{
    [Route("api/Seasons")]
    public class SeasonsController : Controller
    {
        private ISeasonslService SeasonsService;

        public SeasonsController(ISeasonslService _SeasonsService)
        {
            SeasonsService = _SeasonsService;
        }
        // GET: api/Seasons
        [HttpGet]
        [Route("GetSeasonss")]
        public IEnumerable<SeasonsModel> GetSeasons()
        {
            return SeasonsService.GetAll();
        }



        // POST: api/InsertOrUpdateSeasons
        [HttpPost]
        [Route("InsertOrUpdateSeasons")]
        public void Post([FromBody] SeasonsModel SeasonsModel)
        {
            SeasonsService.InsertOrUpdate(SeasonsModel);
        }



        // GET: api/Seasons/5
        //[HttpGet]
        //[Route("GetSeasonsbyId")]
        //public SeasonsModel GetSeasonsByid(int id)
        //{
        //    return SeasonsService.GetSeasonsByid(id);
        //}

        //[HttpDelete]
        //[Route("DeleteSeasons")]
        //public void Delete(int id)
        //{
        //    SeasonsService.DeleteSeasons(id);
        //}

    }
}
