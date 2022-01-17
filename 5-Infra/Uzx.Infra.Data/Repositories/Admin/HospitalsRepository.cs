using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class HospitalsRepository : BaseRepository<Hospitals>, IHospitalsRepository
    {
        public HospitalsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
