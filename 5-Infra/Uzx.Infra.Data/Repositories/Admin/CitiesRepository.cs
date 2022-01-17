using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class CitiesRepository : BaseRepository<Cities>, ICitiesRepository
    {
        public CitiesRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
