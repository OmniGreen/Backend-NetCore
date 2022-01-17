using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Uzx.Application.Interfaces._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Application.Interfaces.Admin
{
    public interface ICustomersGhostApp : IBaseApp<CustomersGhost, CustomersGhostTrans>
    {
        Task<List<CustomersGhostTrans>> GetByApp(CustomersGhostTrans searchRecord);
        Task<CustomersGhostTrans> GetById2(Guid id);
    }
}
