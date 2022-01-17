using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class ClientsOperators : BaseEntityNaoVersionadaClient
    {
        public Guid ClientOperatorId { get; set; }
        public Guid OperatorId { get; set; }
    }
} 