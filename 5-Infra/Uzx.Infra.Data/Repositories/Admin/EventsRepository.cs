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
    public class EventsRepository : BaseRepository<Events>, IEventsRepository
    {
        public readonly UzxBaseDbContext _ctx;
        public EventsRepository(UzxBaseDbContext context)
            : base(context)
        {
            _ctx = context;
        }


        public async Task<List<Events>> GetByApp(Events searchRecord)
        {
            var query = from e in _ctx.Events
                        join c in _ctx.Customers on e.CustomerId equals c.CustomerId
                        join sp in _ctx.SalePlans on c.SalePlanId equals sp.SalePlanId
                        where   e.IsActive == true  && sp.IsGuia == true && c.IsActive ==true  && sp.IsActive ==true
                                && e.IsDeleted == false && c.IsDeleted ==false && sp.IsDeleted ==false
                                && (searchRecord.CategoryId == Guid.Empty || e.CategoryId == searchRecord.CategoryId)
                        select e;

            return await query.ToListAsync();
        }
    }
}
