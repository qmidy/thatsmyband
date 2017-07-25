using Newtonsoft.Json;
using RestClient;
using System.Collections.Generic;
using System.Web.Mvc;
using ThatsMyBandInfrastructure;

namespace ThatsMyBand.Controllers
{
    public class ThatsMyBandController : Controller
    {
        /// <summary>
        /// Renvoie la vue User, page d'accueil
        /// </summary>
        /// <returns></returns>
        public ActionResult UserView()
        {
            var RestClient = new RestClientService("http://thatsmybandrest.azurewebsites.net/");

            string result = RestClient.MakeRequest("api/User/5");

            var user = JsonConvert.DeserializeObject<User>(result);

            return View(user);
        }

        /// <summary>
        /// Renvoie la vue décrivant un joueur
        /// </summary>
        /// <returns></returns>
        public ActionResult PlayerView()
        {
            var RestClient = new RestClientService("http://thatsmybandrest.azurewebsites.net/");

            string result = RestClient.MakeRequest("api/Player/5");

            var player = JsonConvert.DeserializeObject<Player>(result);

            return View(player);
        }

        /// <summary>
        /// Renvoie la vue Plateau, là où le joueur effectue ses actions
        /// </summary>
        /// <returns></returns>
        public ActionResult ScheduleView()
        {
            var RestClient = new RestClientService("http://thatsmybandrest.azurewebsites.net/");

            string result = RestClient.MakeRequest("api/User/5");

            var user = JsonConvert.DeserializeObject<User>(result);

            return View(user);
        }

        /// <summary>
        /// Renvoie la vue décrivant un groupe
        /// </summary>
        /// <returns></returns>
        public ActionResult BandView()
        {
            var RestClient = new RestClientService("http://thatsmybandrest.azurewebsites.net/");

            string result = RestClient.MakeRequest("api/Band/5");

            var band = JsonConvert.DeserializeObject<Band>(result);

            return View(band);
        }
    }
}