using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class UsersPermissionsRepository : BaseRepository<UsersPermissions>, IUsersPermissionsRepository
    {
        public UsersPermissionsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
