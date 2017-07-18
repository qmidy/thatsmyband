using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThatsMyBandInfrastructure
{
    /// <summary>
    /// Répétition
    /// </summary>
    [JsonObject("rehearsal")]
    public class Rehearsal : ScheduleEvent
    {
        /// <summary>
        /// Coût de la répétition
        /// </summary>
        [JsonProperty("cost")]
        public double Cost { get; set; }

        /// <summary>
        /// Qualité de la répétition
        /// </summary>
        [JsonProperty("quality")]
        public double Quality { get; set; }
    }
}
