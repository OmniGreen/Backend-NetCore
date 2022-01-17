using System;
using Uzx.Domain.Entities._Base;


namespace Uzx.Domain.Entities.Admin
{

    public class Address : BaseEntityNaoVersionada
    {
        public Guid AddressId { get; set; }

        public Guid OwnerId { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string Neighborhood { get; set; }

        public string ZipCode { get; set; }

        public string Patio { get; set; }

        public string Number { get; set; }

        public string Complement { get; set; }

        //public AddressTypes AddressTypes { get; set; }
    }
}
