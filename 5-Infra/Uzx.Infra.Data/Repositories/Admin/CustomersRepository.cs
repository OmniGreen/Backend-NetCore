using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using System.Linq.Dynamic;
using Uzx.Infra.Data.Interfaces.Admin;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text;
using System.Globalization;

namespace Uzx.Infra.Data.Repositories.Admin
{


    public class CustomersRepository : BaseRepository<Customers>, ICustomersRepository
    {
        public readonly UzxBaseDbContext _ctx;
        public CustomersRepository(UzxBaseDbContext context)
            : base(context)
        {
            _ctx = context;
        }

        

        public async Task<List<Customers>> GetByApp(Customers searchRecord,bool isDestaque, int qtd)
        {
            var compareInfo = CultureInfo.InvariantCulture.CompareInfo;

            var query = from c in _ctx.Customers
                        join cat in _ctx.Categories on c.CategoryId equals cat.CategoryId
                        join sp in _ctx.SalePlans on c.SalePlanId equals sp.SalePlanId
                        where c.IsActive == true 
                                && c.IsDeleted == false 
                                && sp.IsGuia == true
                                && c.IsGhost == false 
                                && sp.IsDeleted == false 
                                && cat.IsActive == true 
                                && cat.IsDeleted == false
                                && (searchRecord.CategoryId == Guid.Empty || c.CategoryId == searchRecord.CategoryId)
                                && (sp.IsDestaque ==isDestaque)
                                && (searchRecord.Name == null || (
                                //c => c.Name * *like * *"john"
                                    c.Name.ToUpper().Contains(searchRecord.Name.ToUpper())
                                    || c.Description.ToUpper().Contains(searchRecord.Name.ToUpper()) 
                                    || c.Specialties.ToUpper().Contains(searchRecord.Name.ToUpper())
                                    || cat.Name.ToUpper().Contains(searchRecord.Name.ToUpper())
                                    ))
                        select c;




            return await query.Take(qtd).ToListAsync();
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

        public async Task<double> GetFree(Guid searchRecord)
        {
            var query = from c in _ctx.SalePlans
                        where c.IsActive == true
                                && c.SalePlanId == searchRecord
                        select c.Price;
            return query.FirstOrDefault();
        }
        public async Task<List<string>> GetPaymentMethodsByCustomer(Guid searchRecord)
        {

            var ids = from c in _ctx.Customers where c.CustomerId == searchRecord select c.PaymentMethods ;
            var spl = ids.FirstOrDefault().Replace("[", "").Replace("]", "").Replace("\"", "").Trim();
            if (spl != "")
            {

                

            List<Guid> result = spl.Split(new char[] { ',' }).Select(Guid.Parse).ToList();

            var query = from c in _ctx.PaymentMethods
                        where c.IsActive == true
                                && c.IsDeleted ==false
                                && result.Any(x => c.PaymentMethodId.Equals(x))
                        select c.Icon;

            return await query.ToListAsync();
            }
            else
            {
                return new List<string>();
            }
        }
    }
}
