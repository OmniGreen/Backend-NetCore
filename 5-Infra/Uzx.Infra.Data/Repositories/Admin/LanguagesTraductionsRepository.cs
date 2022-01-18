using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class LanguagesTraductionsRepository : BaseRepository<LanguagesTraductions>, ILanguagesTraductionsRepository
    {
        public LanguagesTraductionsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
