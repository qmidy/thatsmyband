using Newtonsoft.Json;
using RestClient;
using System.Collections.Generic;
using System.Web.Mvc;
using ThatsMyBandInfrastructure;

namespace ThatsMyBand.Controllers
{
    public class RestController : Controller
    {
        public ActionResult RestView()
        {
            var RestClient = new RestClientService("http://thatsmybandrest.azurewebsites.net/");

            string result = RestClient.MakeRequest("api/User/5");

            var user = JsonConvert.DeserializeObject<User>(result);

            return View(user);
        }
    }
}