using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class UsersTokensRepository : BaseRepository<UsersTokens>, IUsersTokensRepository
    {
        public UsersTokensRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
