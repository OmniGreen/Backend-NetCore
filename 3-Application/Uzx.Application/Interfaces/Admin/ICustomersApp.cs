using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Uzx.Application.Interfaces._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Application.Interfaces.Admin
{
    public interface ICustomersApp : IBaseApp<Customers, CustomersTrans>
    {
        Task<List<CustomersTrans>> GetByApp(CustomersTrans searchRecord);
        Task<CustomersTrans> GetById2(Guid id);
    }
}
