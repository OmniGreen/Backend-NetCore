using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class Responsabilities : BaseEntityNaoVersionadaClient
    {
        public Guid ResponsabilityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
} 