using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class CitiesTrans : BaseTrans
    {
        public  Guid CityId { get; set; }
        public  Guid StateId { get; set; }
        public string ZipCode { get; set; }
        public string Name { get; set; }
    }
}
