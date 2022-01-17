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
    public class CategoriesRepository : BaseRepository<Categories>, ICategoriesRepository
    {
        public readonly UzxBaseDbContext _ctx;
        public CategoriesRepository(UzxBaseDbContext context)
            : base(context)
        {
            _ctx = context;
        }

        public async Task<List<Categories>> GetByApp(Categories searchRecord)
        {

            var query = (from ct in _ctx.Categories
                         join cst in _ctx.Customers on ct.CategoryId equals cst.CategoryId
                         where ct.IsActive == true && cst.IsActive && ct.IsDeleted == false && cst.IsDeleted == false
                                 && ct.IsEvent == searchRecord.IsEvent
                         select ct).Distinct().ToListAsync();


            return await query;
        }

        public async Task<List<Categories>> GetByAppEvents(Categories searchRecord)
        {

            var query = (from ct in _ctx.Categories
                         join cst in _ctx.Events on ct.CategoryId equals cst.CategoryId
                         where ct.IsActive == true && cst.IsActive && ct.IsDeleted == false && cst.IsDeleted == false
                                 && ct.IsEvent == true
                         select ct).Distinct().ToListAsync();


            return await query;
        }

    }
}
