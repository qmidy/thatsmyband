using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThatsMyBandInfrastructure
{
    /// <summary>
    /// Production réalisée par un groupe de musique
    /// </summary>
    [JsonObject]
    public class Release
    {
        /// <summary>
        /// Id de la Release
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Nom de la Release
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Qualité de la Release
        /// </summary>
        [JsonProperty("quality")]
        public double Quality { get; set; }

        /// <summary>
        /// Morceaux écrits par le groupe pour cette release
        /// </summary>
        [JsonProperty("tracks")]
        public List<Track> Tracks { get; set; }
    }
}
