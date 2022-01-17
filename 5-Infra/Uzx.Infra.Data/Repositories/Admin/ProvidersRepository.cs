using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class ProvidersRepository : BaseRepository<Providers>, IProvidersRepository
    {
        public ProvidersRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
