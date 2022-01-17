using System;
using Uzx.Domain.Entities._Base;


namespace Uzx.Domain.Entities.Admin
{
    public  class ClientsNewsletter: BaseEntityNaoVersionadaClient
    {
        public  Guid ClientNewsletterId { get; set; }
        public  string Email { get; set; }        
    }
} 