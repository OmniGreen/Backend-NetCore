using System;
using System.Collections.Generic;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class Agents : BaseEntityNaoVersionada
    {
        public Guid AgentId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; } 

        //public virtual IEnumerable<Clients> Clients { get; set; }
    }
}