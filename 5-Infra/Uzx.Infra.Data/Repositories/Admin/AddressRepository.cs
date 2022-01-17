using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        public AddressRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
 