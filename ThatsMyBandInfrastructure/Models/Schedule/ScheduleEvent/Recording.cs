using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThatsMyBandInfrastructure
{
    /// <summary>
    /// Enregistrement
    /// </summary>
    [JsonObject("recording")]
    public class Recording : ScheduleEvent
    {
        /// <summary>
        /// Coût de l'enregistrement
        /// </summary>
        [JsonProperty("cost")]
        public double Cost { get; set; }

        /// <summary>
        /// Qualité de l'enregistrement
        /// </summary>
        [JsonProperty("quality")]
        public double Quality { get; set; }
    }
}
