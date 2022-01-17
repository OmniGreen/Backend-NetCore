using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class SystemsMenusRepository : BaseRepository<SystemsMenus>, ISystemsMenusRepository
    {
        public SystemsMenusRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
