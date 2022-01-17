using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class UnionsRepository : BaseRepository<Unions>, IUnionsRepository
    {
        public UnionsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
