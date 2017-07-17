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

        [HttpGet("{id}")]
        public Player Get(string id)
        {
            Player result = new Player() { Name = "Jo", Talent = 99, VocalsSkill = 30, DrumsSkill = 50, Role = RolesEnum.Drums | RolesEnum.Vocals };

            return result;
        }
    }
}
