using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class CidsTrans : BaseTrans
    {

        public Guid CidsId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}