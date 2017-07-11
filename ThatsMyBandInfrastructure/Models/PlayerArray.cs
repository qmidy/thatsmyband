using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThatsMyBandInfrastructure
{
    [JsonArray]
    public class PlayerArray
    {
        /// <summary>
        /// Tableau de player (Model pour sérialisation)
        /// </summary>
        public List<Player> Players { get; set; }
    }
}
