using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class GroupUsersRepository : BaseRepository<GroupUsers>, IGroupUsersRepository
    {
        public GroupUsersRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
