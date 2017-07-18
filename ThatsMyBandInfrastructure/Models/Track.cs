using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThatsMyBandInfrastructure
{
    /// <summary>
    /// Morceau de musique
    /// </summary>
    [JsonObject]
    public class Track
    {
        /// <summary>
        /// Id du morceau de musique
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Nom du morceau de musique
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Qualité du morceau de musique
        /// </summary>
        [JsonProperty("quality")]
        public double Quality { get; set; }
    }
}
