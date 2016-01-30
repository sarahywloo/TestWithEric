using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestWithEric.Domain;
using TestWithEric.Infrastructure;

namespace TestWithEric.Infrastructure {
    public class PlanetRepository : GenericRepository<Planet> {

        public PlanetRepository(DbContext db) : base(db) { }

        public IQueryable<Planet> FindPlanets() {
            return from p in Table
                   where p.Active
                   select p;
        }

    }
}