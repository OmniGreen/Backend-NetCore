using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class SystemsRepository : BaseRepository<Systems>, ISystemsRepository
    {
        public SystemsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
