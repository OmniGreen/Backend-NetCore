using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class KinshipRepository : BaseRepository<Kinship>, IkinshipRepository
    {
        public KinshipRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
