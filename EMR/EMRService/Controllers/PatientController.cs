using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EMRData.PatientModel;

namespace EMRService.Controllers
{
    [RoutePrefix("api/Patient")]
    public class PatientController : ApiController
    {
        [Route("Get")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var result = new PatientDataModel().Get();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
