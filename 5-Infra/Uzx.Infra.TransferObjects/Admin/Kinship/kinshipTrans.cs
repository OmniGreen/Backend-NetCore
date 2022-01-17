using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class KinshipTrans : BaseTrans
    {
        public  Guid KinshipId { get; set; }
        public  string Name { get; set; }
        public string  Description { get; set; }
    }
}