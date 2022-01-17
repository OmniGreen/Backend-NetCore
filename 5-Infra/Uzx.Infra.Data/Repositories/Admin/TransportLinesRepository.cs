using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class TransportLinesRepository : BaseRepository<TransportLines>, ITransportLinesRepository
    {
        public TransportLinesRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
