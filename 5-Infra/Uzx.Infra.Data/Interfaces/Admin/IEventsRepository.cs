using System.Collections.Generic;
using System.Threading.Tasks;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Interfaces._Base;

namespace Uzx.Infra.Data.Interfaces.Admin
{
    public interface IEventsRepository : IBaseRepository<Events>
    {
        Task<List<Events>> GetByApp(Events searchRecord);
    }
}
  