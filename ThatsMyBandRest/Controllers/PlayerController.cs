using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThatsMyBandInfrastructure;

namespace ThatsMyBandRest.Controllers
{
    [Route("api/[controller]")]
    public class PlayerController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Player> Get()
        {
            return new Player[] { new Player { Name = "Name1" } };
        }
    }
}
