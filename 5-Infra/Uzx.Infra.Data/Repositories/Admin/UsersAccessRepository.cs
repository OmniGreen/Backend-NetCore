using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class UsersAccessRepository : BaseRepository<UsersAccess>, IUsersAccessRepository
    {
        public UsersAccessRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
