using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class HigherRepository : BaseRepository<Higher>, IHigherRepository
    {
        public HigherRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
