using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class SpecialitiesRepository : BaseRepository<Specialities>, ISpecialitiesRepository
    {
        public SpecialitiesRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
