using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class SystemsLanguagesRepository : BaseRepository<SystemsLanguages>, ISystemsLanguagesRepository
    {
        public SystemsLanguagesRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
