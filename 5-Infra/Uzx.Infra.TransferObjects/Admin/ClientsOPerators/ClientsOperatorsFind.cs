
using System;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class ClientsOperatorsFind : BaseFind<List<ClientsOperatorsTrans>>
    {
        public string Name { get; set; }
        public int Active { get; set; }
        public bool IsAdmin { get; set; }
        public Guid MatrizClientId { get; set; }
        public Guid UserId { get; set; }
    }
}
