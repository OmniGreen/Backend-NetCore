using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class CostCenterRepository : BaseRepository<CostCenter>, ICostCenterRepository
    {
        public CostCenterRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
