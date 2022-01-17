using System.Collections.Generic;
using System.Threading.Tasks;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Interfaces._Base;

namespace Uzx.Infra.Data.Interfaces.Admin
{
    public interface ICategoriesRepository : IBaseRepository<Categories>
    {
        Task<List<Categories>> GetByApp(Categories searchRecord);

        Task<List<Categories>> GetByAppEvents(Categories searchRecord);
    }
}
 