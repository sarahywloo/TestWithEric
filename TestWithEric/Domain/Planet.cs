using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWithEric.Domain {
    public class Planet : IDbEntity, IActivatable {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Distance { get; set; }

        public bool Active { get; set; } = true;
    }
}