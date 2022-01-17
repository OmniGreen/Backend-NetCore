using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class Specialities : BaseEntityNaoVersionadaClient
    {
        public Guid SpecialityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
} 