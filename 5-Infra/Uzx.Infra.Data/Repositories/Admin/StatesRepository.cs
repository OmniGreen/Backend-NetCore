using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class StatesRepository : BaseRepository<States>, IStatesRepository
    {
        public StatesRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
