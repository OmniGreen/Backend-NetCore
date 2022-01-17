using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class StatusSolicitationRepository : BaseRepository<StatusSolicitation>, IStatusSolicitationRepository
    {
        public StatusSolicitationRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
