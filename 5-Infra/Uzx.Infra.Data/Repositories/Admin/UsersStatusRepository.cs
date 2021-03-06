using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class UsersStatusRepository : BaseRepository<UsersStatus>, IUsersStatusRepository
    {
        public UsersStatusRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
