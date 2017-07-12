using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ThatsMyBandInfrastructure
{
    /// <summary>
    /// Utilisateur de l'application (Id FB)
    /// </summary>
    [JsonObject]
    public class User
    {
        /// <summary>
        /// Id de l'utilisateur
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Groupes dont dispose l'utilisateur
        /// </summary>
        [JsonProperty("bands")]
        public List<Band> Bands { get; set; }
    }
}
