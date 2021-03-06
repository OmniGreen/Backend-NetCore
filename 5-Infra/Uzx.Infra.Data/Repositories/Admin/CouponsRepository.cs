using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class CouponsRepository : BaseRepository<Coupons>, ICouponsRepository
    {
        public CouponsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
