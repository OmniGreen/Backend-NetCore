using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class TransportsRepository : BaseRepository<Transports>, ITransportsRepository
    {
        public TransportsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
