using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class AddressTrans : BaseTrans
    { 
        public  Guid AddressId { get; set; }
        public  Guid OwnerId { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string ZipCode { get; set; }
        public string Patio { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public  AddressTypesTrans AddressTypes { get; set; }
    }

    public  class AddressTypesTrans : BaseTrans
    {
        public  Guid AdressTypeId { get; set; }
        public  string Name { get; set; }
        public  string Description { get; set; }
    }
}
