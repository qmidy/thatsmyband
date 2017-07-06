using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient
{
    public interface IRestClientService
    {
        /// <summary>
        /// URI du service REST avec lequel on communique
        /// </summary>
        string EndPoint { get; set; }

        /// <summary>
        /// Méthode HTTP utilisée pour dialoguer avec le client
        /// </summary>
        HttpVerbEnum Method { get; set; }

        /// <summary>
        /// Content-Type de la requête Http (par exemple : "text/xml")
        /// </summary>
        string ContentType { get; set; }

        /// <summary>
        /// Donnée envoyée au serveur si la requête est POST
        /// </summary>
        string PostData { get; set; }

        /// <summary>
        /// Envoie une requête vide au serveur
        /// </summary>
        /// <returns></returns>
        string MakeRequest();

        /// <summary>
        /// Envoie une requête avec des paramètres au serveur
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        string MakeRequest(string parameters);
    }
}
