using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class CountryFind : BaseFind<List<CountriesTrans>>
    {
        public string Name { get; set; }
        public string Acronym { get; set; }
    }
}
