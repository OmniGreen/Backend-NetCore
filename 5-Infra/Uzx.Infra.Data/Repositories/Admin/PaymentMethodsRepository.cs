using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects.Admin;
using System.Threading.Tasks;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class PaymentMethodsRepository : BaseRepository<PaymentMethods>, IPaymentMethodsRepository
    {
        public readonly UzxBaseDbContext _ctx;
        public PaymentMethodsRepository(UzxBaseDbContext context)
            :base(context)
        {
            _ctx = context;
        }

        //public async Task<List<PaymentMethods>> Remove(Guid id)
        //{
        //    var item = await _dbSet.FindAsync(id);
        //    //_dbSet.Remove(item);
        //    item.IsDeleted = true;
        //    item.DtDeleted = DateTime.Now;
        //    _dbSet.Update(item);
        //    await Db.SaveChangesAsync();

        //    var query = from c in _ctx.Customers
        //                where c.IsActive == true
        //                        && c.IsDeleted == false
        //                select c;



        //    return await _dbSet.Where(p => p.IsActive == true).ToListAsync();
        //}


    }
}
