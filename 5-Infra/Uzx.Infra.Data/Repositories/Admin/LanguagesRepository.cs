using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class LanguagesRepository : BaseRepository<Languages>, ILanguagesRepository
    {
        public LanguagesRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
