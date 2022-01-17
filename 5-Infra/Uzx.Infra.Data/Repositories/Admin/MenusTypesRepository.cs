using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class MenusTypesRepository : BaseRepository<MenusTypes>, IMenusTypesRepository
    {
        public MenusTypesRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
