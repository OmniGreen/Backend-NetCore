using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class ClientsContactsTrans : BaseTrans
    {
        public  Guid ClientContactId { get; set; }
        public  string ContactName { get; set; }
        public  string ContactEmail { get; set; }
        public  string ContactSector { get; set; }
    }
}
