using System;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class StateFind : BaseFind<List<StatesTrans>>
    {
        public Guid CountryId { get; set; }
        public string Name { get; set; }
        public string Acronym { get; set; }
    }
}
