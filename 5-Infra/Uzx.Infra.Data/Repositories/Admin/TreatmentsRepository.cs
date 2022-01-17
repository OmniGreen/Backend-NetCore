using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class TreatmentsRepository : BaseRepository<Treatments>, ITreatmentsRepository
    {
        public TreatmentsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
