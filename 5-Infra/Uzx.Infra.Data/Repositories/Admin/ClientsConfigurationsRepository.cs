using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class ClientsConfigurationsRepository : BaseRepository<ClientsConfigurations>, IClientsConfigurationsRepository
    {
        public ClientsConfigurationsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
