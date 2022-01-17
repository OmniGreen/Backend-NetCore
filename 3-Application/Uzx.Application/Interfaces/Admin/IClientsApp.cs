﻿using Uzx.Domain.Entities._Base;
using Uzx.Application.Interfaces._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Application.Interfaces.Admin
{
    public interface IClientsApp : IBaseApp<Clients, ClientsTrans>
    {
        public ClientsFind List(ClientsFind searchRecord);
    }
   
}
 