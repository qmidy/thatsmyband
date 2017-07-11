using Newtonsoft.Json;
using RestClient;
using System.Web.Mvc;
using ThatsMyBandInfrastructure;

namespace ThatsMyBand.Controllers
{
    public class RestController : Controller
    {
        #region Public Properties

        private Band _band;
        public Band Band {
            get
            {
                return _band;
            }
            set
            {
                if (value != _band)
                    _band = value;
            }
        }

        #endregion

        public ActionResult RestView()
        {
            var RestClient = new RestClientService("http://thatsmybandrest.azurewebsites.net/");

            string result = RestClient.MakeRequest("api/Band");

            var Band = JsonConvert.DeserializeObject<Band>(result);

            return View();
        }
    }
}