using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class UsersTypesRepository : BaseRepository<Users>, IUsersRepository
    {
        public UsersTypesRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
