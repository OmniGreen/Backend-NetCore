using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class FamilyTypeRepository : BaseRepository<FamilyType>, IFamilyTypeRepository
    {
        public FamilyTypeRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
