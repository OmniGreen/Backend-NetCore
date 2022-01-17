using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class ShiftsRepository : BaseRepository<Shifts>, IShiftsRepository
    {
        public ShiftsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
