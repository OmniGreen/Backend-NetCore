using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Interfaces._Base;

namespace Uzx.Infra.Data.Interfaces.Admin
{
    public interface ICustomersRepository : IBaseRepository<Customers>
    {
        Task<List<Customers>> GetByApp(Customers searchRecord, bool isDestaque, int qtd);
        Task<string> GetCategoryName(Guid searchRecord);
        Task<bool> GetDestaque(Guid searchRecord);
        Task<double> GetFree(Guid searchRecord);
        Task<List<string>> GetPaymentMethodsByCustomer(Guid searchRecord);
        

    }
}
