using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class DoctorsRepository : BaseRepository<Doctors>, IDoctorsRepository
    {
        public DoctorsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
