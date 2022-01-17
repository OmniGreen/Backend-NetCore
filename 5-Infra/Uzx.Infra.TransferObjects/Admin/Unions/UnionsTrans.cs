using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class UnionsTrans : BaseTrans
    {
        public Guid UnionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}