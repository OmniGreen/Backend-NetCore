using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class AddressTypesRepository : BaseRepository<AddressTypes>, IAddressTypesRepository
    {
        public AddressTypesRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
