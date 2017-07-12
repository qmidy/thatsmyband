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
            players.Add(new Player() { Name = "Jo", Instrument = InstrumentEnum.Drums | InstrumentEnum.Vocals });
            players.Add(new Player() { Name = "Raf", Instrument = InstrumentEnum.Guitar });
            players.Add(new Player() { Name = "Adrien", Instrument = InstrumentEnum.Bass | InstrumentEnum.Vocals });
            players.Add(new Player() { Name = "Quentin", Instrument = InstrumentEnum.Guitar | InstrumentEnum.Vocals });

            Band band = new Band() { Name = "Band Test", Players = players };

            return new List<Band> { band };
        }
    }
}
