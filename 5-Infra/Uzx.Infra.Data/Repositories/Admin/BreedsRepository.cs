using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class BreedsRepository : BaseRepository<Breeds>, IBreedsRepository
    {
        public BreedsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
