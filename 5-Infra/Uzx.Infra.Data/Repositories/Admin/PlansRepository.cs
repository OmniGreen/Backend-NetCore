using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class PlansRepository : BaseRepository<Plans>, IPlansRepository
    {
        public PlansRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
