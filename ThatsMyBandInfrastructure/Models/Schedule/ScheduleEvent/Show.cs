using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThatsMyBandInfrastructure
{
    /// <summary>
    /// Concert
    /// </summary>
    [JsonObject("show")]
    public class Show : ScheduleEvent
    {
        /// <summary>
        /// Qualité du concert (i.e. de la salle) 
        /// </summary>
        [JsonProperty("quality")]
        public double Quality { get; set; }
    }
}
