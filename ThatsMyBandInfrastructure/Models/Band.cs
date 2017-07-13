using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ThatsMyBandInfrastructure
{
    /// <summary>
    /// Groupe de musique
    /// </summary>
    [JsonObject]
    public class Band
    {
        /// <summary>
        /// Id du Groupe
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Nom du Groupe
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Reputation du Groupe
        /// </summary>
        [JsonProperty("fame")]
        public double Fame { get; set; }

        /// <summary>
        /// Joueurs du Groupe
        /// </summary>
        [JsonProperty("players")]
        public List<Player> Players { get; set; }
    }
}
