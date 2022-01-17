using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class AddressTypes : BaseEntity
    { 
        public Guid AdressTypesId { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; }
    }
}
