using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class FunctionsRepository : BaseRepository<Functions>, IFunctionsRepository
    {
        public FunctionsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
