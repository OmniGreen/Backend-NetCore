using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class ProceduresRepository : BaseRepository<Procedures>, IProceduresRepository
    {
        public ProceduresRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
