
using System;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class ClientsFind : BaseFind<List<ClientsTrans>>
    {
        public string Name { get; set; }
        public string Active { get; set; }
        public string IsAdmin { get; set; }
        public Guid MatrizClientId { get; set; }
        public Guid UserId { get; set; }
    }
}
