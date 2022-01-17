using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class Countries : BaseEntityNaoVersionada
    {
        public Guid CountryId { get; set; }

        public string Name { get; set; }

        public string Acronym { get; set; }
    }
} 