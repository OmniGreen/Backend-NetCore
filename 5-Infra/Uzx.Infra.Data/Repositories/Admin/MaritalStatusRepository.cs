using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class MaritalStatusRepository : BaseRepository<MaritalStatus>, IMaritalStatusRepository
    {
        public MaritalStatusRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
