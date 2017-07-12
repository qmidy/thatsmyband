using Newtonsoft.Json;
using RestClient;
using System.Collections.Generic;
using System.Web.Mvc;
using ThatsMyBand.Models;
using ThatsMyBandInfrastructure;

namespace ThatsMyBand.Controllers
{
    public class RestController : Controller
    {
        #region Public Properties

        private BandModel _bandModel;
        public BandModel BandModel
        {
            get
            {
                return _bandModel;
            }
            set
            {
                if(value != _bandModel)
                    _bandModel = value;
            }
        }

        #endregion

        public ActionResult RestView()
        {
            var RestClient = new RestClientService("http://thatsmybandrest.azurewebsites.net/");

            string result = RestClient.MakeRequest("api/Band");

            var bands = JsonConvert.DeserializeObject<List<Band>>(result);

            _bandModel = new BandModel() { Band = bands[0] };

            return View(_bandModel);
        }
    }
}