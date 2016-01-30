using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestWithEric.Presentation.ngApp.services;
using TestWithEric.Services.Models;

namespace TestWithEric.Presentation.Controllers
{
    public class PlanetController : ApiController {

        private PlanetService _planetService;

        public PlanetController(PlanetService planetService) {
            _planetService = planetService;
        }

        [HttpGet]
        public IList<PlanetDTO> Get() {
            return _planetService.GetPlanets();
        }

        [HttpPost]
        public IHttpActionResult addPlanet(PlanetDTO planet) {
            if(ModelState.IsValid) {
                return Ok(_planetService.AddPlanet(new PlanetDTO() {
                    Name = planet.Name,
                    Distance = planet.Distance
                }));
            }
            return BadRequest();
        }

    }
}
