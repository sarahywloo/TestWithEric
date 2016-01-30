using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestWithEric.Domain;
using TestWithEric.Infrastructure;
using TestWithEric.Services.Models;

namespace TestWithEric.Presentation.ngApp.services {
    public class PlanetService {

        private PlanetRepository _planetRepo;

        public PlanetService (PlanetRepository planetRepo) {
            _planetRepo = planetRepo;
        }

        public IList<PlanetDTO> GetPlanets() {
            return (from p in _planetRepo.FindPlanets()
                    select new PlanetDTO() {
                        Name = p.Name,
                        Distance = p.Distance
                    }).ToList();
        }

        public PlanetDTO AddPlanet(PlanetDTO dto) {
            var planet = new Planet() {
                Name = dto.Name,
                Distance = dto.Distance
            };

            _planetRepo.Add(planet);
            _planetRepo.SaveChanges();

            return new PlanetDTO() {
                Name = planet.Name,
                Distance = planet.Distance
            };
        }
    }
}