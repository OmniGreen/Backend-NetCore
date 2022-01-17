using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class HigherTrans : BaseTrans
    {
        public Guid HigherId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}