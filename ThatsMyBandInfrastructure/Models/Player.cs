using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ThatsMyBandInfrastructure
{
    /// <summary>
    /// Joueur d'un groupe de musique
    /// </summary>
    [JsonObject]
    public class Player
    {
        /// <summary>
        /// Id du Joueur
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Nom du Joueur
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Instrument maîtrisé par le joueur
        /// </summary>
        [JsonProperty("instrument")]
        public  InstrumentEnum Instrument { get; set; }
    }
}
