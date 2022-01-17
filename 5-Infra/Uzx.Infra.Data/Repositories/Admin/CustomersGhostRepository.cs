using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using System.Linq.Dynamic;
using Uzx.Infra.Data.Interfaces.Admin;
using Microsoft.EntityFrameworkCore;
using System;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class CustomersGhostRepository : BaseRepository<CustomersGhost>, ICustomersGhostRepository
    {
        public readonly UzxBaseDbContext _ctx;
        public CustomersGhostRepository(UzxBaseDbContext context)
            : base(context)
        {
            _ctx = context;
        }

        public async Task<List<CustomersGhost>> GetByApp(CustomersGhost searchRecord)
        {
            var query = from c in _ctx.CustomersGhost
                        join sp in _ctx.SalePlans on c.SalePlanId equals sp.SalePlanId
                        where c.IsActive == true && sp.IsGuia == true
                                && (searchRecord.CategoryId == Guid.Empty || c.CategoryId == searchRecord.CategoryId)
                                && (searchRecord.Name == null || c.Name.ToUpper().Contains(searchRecord.Name.ToUpper()))
                        select c;

            return await query.ToListAsync();
        }


        public async Task<string> GetCategoryName(Guid searchRecord)
        {
            var query = from c in _ctx.Categories
                        where c.IsActive == true
                                && c.CategoryId == searchRecord
                        select c.Name;
            return query.FirstOrDefault();
        }
        public async Task<bool> GetDestaque(Guid searchRecord)
        {
            var query = from c in _ctx.SalePlans
                        where c.IsActive == true
                                && c.SalePlanId == searchRecord
                        select c.IsDestaque;
            return query.FirstOrDefault();
        }
        public async Task<List<string>> GetPaymentMethodsByCustomer(Guid searchRecord)
        {

            var ids = from c in _ctx.CustomersGhost where c.CustomerGhostId == searchRecord select c.PaymentMethods;
            List<Guid> result = ids.FirstOrDefault().Replace("[", "").Replace("]", "").Replace("\"", "").Trim().Split(new char[] { ',' }).Select(Guid.Parse).ToList();

            var query = from c in _ctx.PaymentMethods
                        where c.IsActive == true
                                && result.Any(x => c.PaymentMethodId.Equals(x))
                        select c.Icon;

            return await query.ToListAsync();
        }
    }
}
