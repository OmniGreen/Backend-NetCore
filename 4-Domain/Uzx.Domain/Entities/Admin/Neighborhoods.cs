using System;
using System.Collections.Generic;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin {
    public class Neighborhoods : BaseEntityNaoVersionadaClient {
        public Guid NeighborhoodId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
