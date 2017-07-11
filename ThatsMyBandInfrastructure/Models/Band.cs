using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ThatsMyBandInfrastructure
{
    /// <summary>
    /// Groupe de musique
    /// </summary>
    public class Band
    {
        /// <summary>
        /// Id du Groupe
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Nom du Groupe
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Joueurs du Groupe
        /// </summary>
        public PlayerArray PlayerList { get; set; }
    }
}
