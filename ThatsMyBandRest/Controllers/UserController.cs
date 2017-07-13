using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThatsMyBandInfrastructure;

namespace ThatsMyBandRest.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return new List<User>();
        }

        [HttpGet("{id}")]
        public User Get(string id)
        {
            User result = new User();

            // Création des Players
            List<Player> players = new List<Player>();
            players.Add(new Player() { Name = "Jo", Talent = 99, VocalsSkill = 30, DrumsSkill = 50, Role = RolesEnum.Drums | RolesEnum.Vocals });
            players.Add(new Player() { Name = "Raf", Talent = 99, GuitarSkill = 70, VocalsSkill = 10, Role = RolesEnum.Guitar });
            players.Add(new Player() { Name = "Adrien", Talent = 99, BassSkill = 40, VocalsSkill = 40, Role = RolesEnum.Bass | RolesEnum.Vocals });
            players.Add(new Player() { Name = "Quentin", Talent = 99, VocalsSkill = 50, GuitarSkill = 30, Role = RolesEnum.Guitar | RolesEnum.Vocals });

            // Création du Groupe
            Band band = new Band() { Name = "Band Test", Fame = 52, Players = players };

            // Création du User
            result.Bands = new List<Band>() { band };
            result.Cash = 100;

            return result;
        }
    }
}
