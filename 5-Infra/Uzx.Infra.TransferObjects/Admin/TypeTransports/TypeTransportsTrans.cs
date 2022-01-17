using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class TypeTransportsTrans : BaseTrans
    {
        public Guid TypeTransportId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}