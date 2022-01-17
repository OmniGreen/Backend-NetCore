using System;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class AddressFind : BaseFind<List<AddressTrans>>
    {
        public Guid OwnerId { get; set; }
    }
}
