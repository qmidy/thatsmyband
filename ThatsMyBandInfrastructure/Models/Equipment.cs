using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThatsMyBandInfrastructure
{
    /// <summary>
    /// Equipement du musicien (Ampli, Batterie...)
    /// </summary>
    [JsonObject]
    public class Equipment
    {
        /// <summary>
        /// Id de l'équipement
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Nom de l'équipement
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Qualité de l'équipement
        /// </summary>
        [JsonProperty("quality")]
        public double Quality { get; set; }
    }
}
