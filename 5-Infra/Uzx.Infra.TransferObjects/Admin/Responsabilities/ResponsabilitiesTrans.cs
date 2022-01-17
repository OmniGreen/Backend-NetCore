using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class ResponsabilitiesTrans : BaseTrans
    {
        public Guid ResponsabilityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}