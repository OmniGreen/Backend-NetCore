using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public  class ClientsSystems : BaseEntityNaoVersionadaClient
    {
        public  Guid ClientSystemId { get; set; }       
        public  Guid SystemId { get; set; }
        public  Systems System { get; set; }
    }
} 