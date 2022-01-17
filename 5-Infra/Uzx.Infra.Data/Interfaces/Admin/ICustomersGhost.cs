using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Interfaces._Base;

namespace Uzx.Infra.Data.Interfaces.Admin
{
    public interface ICustomersGhostRepository : IBaseRepository<CustomersGhost>
    {
        Task<List<CustomersGhost>> GetByApp(CustomersGhost searchRecord);
        Task<string> GetCategoryName(Guid searchRecord);
        Task<bool> GetDestaque(Guid searchRecord);
        Task<List<string>> GetPaymentMethodsByCustomer(Guid searchRecord);
        

    }
}
