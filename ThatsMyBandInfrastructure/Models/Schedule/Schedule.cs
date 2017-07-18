using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThatsMyBandInfrastructure
{
    /// <summary>
    /// Calendrier
    /// </summary>
    [JsonObject]
    public class Schedule
    {
        /// <summary>
        /// Id du Calendrier
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Liste des événement du calendrier
        /// </summary>
        [JsonProperty("scheduleevents")]
        public List<ScheduleEvent> ScheduleEvents {get;set;}
    }
}
