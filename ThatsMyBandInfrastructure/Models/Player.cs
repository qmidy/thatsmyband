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
        /// Talent du joueur / Aptitude à apprendre rapidement
        /// </summary>
        [JsonProperty("talent")]
        public double Talent { get; set; }

        /// <summary>
        /// Experience dont dispose le joueur
        /// </summary>
        [JsonProperty("experience")]
        public double Experience { get; set; }

        /// <summary>
        /// Equipement du musicien
        /// </summary>
        [JsonProperty("equipment")]
        public Equipment Equipment { get; set; }

        /// <summary>
        /// Instruments joués par le joueur
        /// </summary>
        [JsonProperty("instrument")]
        public  RolesEnum Role { get; set; }

        #region Skills
        /// <summary>
        /// Décrit le niveau à la basse
        /// </summary>
        [JsonProperty("bassskill")]
        public double BassSkill { get; set; }

        /// <summary>
        /// Décrit le niveau de coordination, la faculté de jouer deux instruments à la fois
        /// </summary>
        [JsonProperty("coordinationskill")]
        public double CoordinationSkill { get; set; }

        /// <summary>
        /// Décrit le niveau à la batterie
        /// </summary>
        [JsonProperty("drumsskill")]
        public double DrumsSkill { get; set; }

        /// <summary>
        /// Décrit le niveau à la guitare
        /// </summary>
        [JsonProperty("guitarskill")]
        public double GuitarSkill { get; set; }

        /// <summary>
        /// Décrit le niveau au chant
        /// </summary>
        [JsonProperty("vocalsskill")]
        public double VocalsSkill { get; set; }
        #endregion
    }
}
