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
            List<Player> players = new List<Player>();
            players.Add(new Player() { Name = "Jo", Role = RolesEnum.Drums | RolesEnum.Vocals });
            players.Add(new Player() { Name = "Raf", Role = RolesEnum.Guitar });
            players.Add(new Player() { Name = "Adrien", Role = RolesEnum.Bass | RolesEnum.Vocals });
            players.Add(new Player() { Name = "Quentin", Role = RolesEnum.Guitar | RolesEnum.Vocals });

            Band band = new Band() { Name = "Band Test", Players = players };

            return new List<Band> { band };
        }
    }
}
