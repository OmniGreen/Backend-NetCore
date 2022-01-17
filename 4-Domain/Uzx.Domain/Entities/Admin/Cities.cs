using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class Cities : BaseEntityNaoVersionada
    {
        public Guid CityId { get; set; }

        public Guid StateId { get; set; }

        public string ZipCode { get; set; }

        public string Name { get; set; }
    }
}