using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class UsersPermissionsMenusRepository : BaseRepository<UsersPermissionsMenus>, IUsersPermissionsMenusRepository
    {
        public UsersPermissionsMenusRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
