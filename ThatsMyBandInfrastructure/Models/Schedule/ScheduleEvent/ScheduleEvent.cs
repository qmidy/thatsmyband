using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThatsMyBandInfrastructure
{
    /// <summary>
    /// Evénement de calendrier 
    /// </summary>
    [JsonObject]
    public class ScheduleEvent
    {
        /// <summary>
        /// Id de l'événement dans le calendrier
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Date de l'événement dans le calendrier
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }
    }
}
