using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class BannersRepository : BaseRepository<Banners>, IBannersRepository
    {
        public BannersRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
