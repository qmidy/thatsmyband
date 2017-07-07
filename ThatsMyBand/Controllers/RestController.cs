using RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThatsMyBand.Controllers
{
    public class RestController : Controller
    {
        public ActionResult RestView()
        {
            var RestClient = new RestClientService("http://thatsmybandrest.azurewebsites.net/");

            string result = RestClient.MakeRequest("api/Band");   

            return View();
        }
    }
}