using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThatsMyBandInfrastructure;

namespace ThatsMyBandRest.Controllers
{
    [Route("api/[controller]")]
    public class BandController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Band> Get()
        {
            List<Player> players = new List<Player>();
            players.Add(new Player() { Name = "Jo", Role = RolesEnum.Drums | RolesEnum.Vocals });
            players.Add(new Player() { Name = "Raf", Role = RolesEnum.Guitar });
            players.Add(new Player() { Name = "Adrien", Role = RolesEnum.Bass | RolesEnum.Vocals });
            players.Add(new Player() { Name = "Quentin", Role = RolesEnum.Guitar | RolesEnum.Vocals });

            Band band = new Band() { Name = "Band Test", Players = players };

            return new List<Band> { band };
        }

        [HttpGet("{id}")]
        public Band Get(string id)
        {
            // Création des Players
            List<Player> players = new List<Player>();
            players.Add(new Player() { Name = "Jo", Talent = 99, VocalsSkill = 30, DrumsSkill = 50, Role = RolesEnum.Drums | RolesEnum.Vocals });
            players.Add(new Player() { Name = "Raf", Talent = 99, GuitarSkill = 70, VocalsSkill = 10, Role = RolesEnum.Guitar });
            players.Add(new Player() { Name = "Adrien", Talent = 99, BassSkill = 40, VocalsSkill = 40, Role = RolesEnum.Bass | RolesEnum.Vocals });
            players.Add(new Player() { Name = "Quentin", Talent = 99, VocalsSkill = 50, GuitarSkill = 30, Role = RolesEnum.Guitar | RolesEnum.Vocals });

            // Création du Calendrier
            List<ScheduleEvent> scheduleEvents = new List<ScheduleEvent>();
            scheduleEvents.Add(new Recording() { Cost = 100, Date = new DateTime(), Quality = 200 });
            scheduleEvents.Add(new Rehearsal() { Cost = 100, Date = new DateTime(), Quality = 200 });
            scheduleEvents.Add(new Show() { Date = new DateTime(), Quality = 200 });

            Schedule schedule = new Schedule() { ScheduleEvents = scheduleEvents };

            // Création des morceaux
            List<Track> tracks = new List<Track>();
            tracks.Add(new Track() { Name = "Track1", Quality = 200 });
            tracks.Add(new Track() { Name = "Track2", Quality = 200 });

            // Création des Releases
            List<Release> releases = new List<Release>();
            releases.Add(new Release() { Name = "Release1", Quality = 200, Tracks = tracks });

            // Création du Groupe
            Band band = new Band() { Name = "Band Test", Fame = 52, Players = players, Schedule = schedule, Releases = releases };

            return band;
        }
    }
}
