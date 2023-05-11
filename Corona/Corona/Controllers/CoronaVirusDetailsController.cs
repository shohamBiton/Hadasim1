using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
namespace WebApi.Controllers
{
    [RoutePrefix("api/coronaVirusDetails")]
    public class CoronaVirusDetailsController:ApiController
    {
        [Route("getAll")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(CoronaVirusDetailsBLL.GetAll());
        }
        [Route("GetNotVaccinatedNum")]
        [HttpGet]
        public IHttpActionResult GetNotVaccinatedNum()
        {
            return Ok(CoronaVirusDetailsBLL.GetNotVaccinatedNum());
        }

        [Route("add")]
        [HttpPut]
        public IHttpActionResult Add(CoronaVirusDetailsEntities coronaVirusDetailsEntities)
        {
            CoronaVirusDetailsBLL.Add(coronaVirusDetailsEntities);
            return Ok();
        }

    }
}
