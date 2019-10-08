using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimalTemplate.Controllers.V1
{
    [Route("api/v1/health")]
    [Produces("application/json")]
    public class HealthCheckController : AbstractController
    {
        // constants
        private const string RouteGetHealth = "MyHealth";


        [HttpGet(Name = RouteGetHealth)]
        public ActionResult Get()
        {
            return Ok(new { message = "I'm Ok"});
        }
    }
}
