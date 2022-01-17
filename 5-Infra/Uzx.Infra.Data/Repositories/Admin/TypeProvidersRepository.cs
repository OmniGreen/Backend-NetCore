using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class TypeProvidersRepository : BaseRepository<TypeProviders>, ITypeProvidersRepository
    {
        public TypeProvidersRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
