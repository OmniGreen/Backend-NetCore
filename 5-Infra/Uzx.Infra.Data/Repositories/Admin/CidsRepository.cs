using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class CidsRepository : BaseRepository<Cids>, ICidsRepository
    {
        public CidsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
