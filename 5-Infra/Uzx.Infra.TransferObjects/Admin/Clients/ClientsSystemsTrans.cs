using System;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class ClientsSystemsTrans : BaseTrans
    {
        public  Guid ClientSystemId { get; set; }
        public  Guid SystemId { get; set; }
        public  List<SystemsTrans> ListSystems { get; set; }
    }
}
