using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class TypeTransportsRepository : BaseRepository<TypeTransports>, ITypeTransportsRepository
    {
        public TypeTransportsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
