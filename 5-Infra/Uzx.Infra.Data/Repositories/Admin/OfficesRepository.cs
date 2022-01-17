using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class OfficesRepository : BaseRepository<Offices>, IOfficesRepository
    {
        public OfficesRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
