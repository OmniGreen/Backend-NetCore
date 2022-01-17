using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class ClientsContactsRepository : BaseRepository<ClientsContacts>, IClientsContactsRepository
    {
        public ClientsContactsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
