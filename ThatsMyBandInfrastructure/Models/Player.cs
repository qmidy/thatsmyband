using System;
using System.Collections.Generic;
using System.Text;

namespace ThatsMyBandInfrastructure
{
    /// <summary>
    /// Joueur d'un groupe de musique
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Id du Joueur
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Nom du Joueur
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Instrument maîtrisé par le joueur
        /// </summary>
        public  InstrumentEnum Instrument { get; set; }
    }
}
