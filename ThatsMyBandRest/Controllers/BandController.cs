using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThatsMyBandInfrastructure;

namespace ThatsMyBandRest.Controllers
{
    [Route("api/[controller]")]
    public class BandController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Band> Get()
        {
            return new Band[] { new Band { Name = "Name1" } };
        }
    }
}
