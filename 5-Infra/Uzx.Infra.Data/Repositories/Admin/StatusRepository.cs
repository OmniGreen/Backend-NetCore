using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class StatusRepository : BaseRepository<Status>, IStatusRepository
    {
        public StatusRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
