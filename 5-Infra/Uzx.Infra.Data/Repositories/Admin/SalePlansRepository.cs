using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class SalePlansRepository : BaseRepository<SalePlans>, ISalePlansRepository
    {
        public SalePlansRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
