using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public  class ClientsContacts : BaseEntityNaoVersionadaClient
    {
        public  Guid ClientContactId { get; set; }
        public  string ContactName { get; set; }
        public  string ContactEmail { get; set; }
        public  string ContactSector { get; set; }
    }
} 