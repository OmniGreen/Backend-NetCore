using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class ProvidersTrans : BaseTrans
    {
        public Guid ProviderId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}