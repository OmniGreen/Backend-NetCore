using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class ClientsOperatorsRepository : BaseRepository<ClientsOperators>, IClientsOperatorsRepository
    {
        public ClientsOperatorsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
