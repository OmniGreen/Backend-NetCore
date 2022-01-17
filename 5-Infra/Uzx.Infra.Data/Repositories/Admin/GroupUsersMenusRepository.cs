using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class GroupUsersMenusRepository : BaseRepository<GroupUsersMenus>, IGroupUsersMenusRepository
    {
        public GroupUsersMenusRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
