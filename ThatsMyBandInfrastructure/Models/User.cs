using System;
using System.Collections.Generic;
using System.Text;

namespace ThatsMyBandInfrastructure
{
    /// <summary>
    /// Utilisateur de l'application (Id FB)
    /// </summary>
    public class User
    {
        /// <summary>
        /// Id de l'utilisateur
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Groupes dont dispose l'utilisateur
        /// </summary>
        public List<Band> BandList { get; set; }
    }
}
